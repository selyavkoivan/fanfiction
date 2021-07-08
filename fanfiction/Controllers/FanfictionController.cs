using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using fanfiction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using fanfiction.Models.User;
using System.Threading.Tasks;
using EmailApp;
using fanfiction.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Mvc;
using fanfiction.Models.Fanfiction;
using Microsoft.AspNetCore.Http;

namespace fanfiction.Controllers
{
    public class FanfictionController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext _context;
        
        public FanfictionController(ApplicationDbContext context,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._context = context;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
       [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> Fanfiction()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View(new FanfictionModel(_context, Request.Cookies["lang"]));
        }
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> AddFandom()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View();
        }
      
        
        public async Task<bool> LogoutUser()
        {
            ApplicationUser user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            if (user == null) await _signInManager.SignOutAsync();
            else if (user.Status) await _signInManager.SignOutAsync();
            return (user == null || user.Status);
        }
        
       private async Task<bool> CheckFandom(Fandom fandom)
        {
            TempData["Fandom-name-en"] = await GetFandomMsgEn(fandom.EnName);
            TempData["Fandom-name-ru"] = await  GetFandomMsgRu(fandom.RuName);
            if (TempData["Fandom-name-ru"] != null || TempData["Fandom-name-en"] != null) return false;
            return true;
        }

        private async Task<string> GetFandomMsgEn(string name)
        {
            if (await _context.Fandoms.FirstOrDefaultAsync(f => f.EnName == name) != null) return "Error";
            return null;
        }
        private async Task<string> GetFandomMsgRu(string name)
        {
            if (await _context.Fandoms.FirstOrDefaultAsync(f => f.RuName == name) != null) return "Error";
            return null;
        }
        [HttpPost]
        public async Task<ActionResult> AddFandom(Fandom fandom)
        {
            
         if (!await CheckFandom(fandom)) return View();
            await _context.Fandoms.AddAsync(fandom);
            await _context.SaveChangesAsync();
            TempData["Adding-success"] = FanfictionErrors.getFandomSuccess(Request.Cookies["lang"]);
            return RedirectToAction("Fanfiction", "Fanfiction");
        }
        
        
        private async Task<bool> CheckGenre(Genre genre)
        {
            TempData["Genre-name-en"] = await GetGenreMsgEn(genre.EnName);
            TempData["Genre-name-ru"] = await  GetGenreMsgRu(genre.RuName);
            if (TempData["Genre-name-ru"] != null || TempData["Genre-name-en"] != null) return false;
            return true;
        }

        private async Task<string> GetGenreMsgEn(string name)
        {
            if (await _context.Genres.FirstOrDefaultAsync(f => f.EnName == name) != null) return "Error";
            return null;
        }
        private async Task<string> GetGenreMsgRu(string name)
        {
            if (await _context.Genres.FirstOrDefaultAsync(f => f.RuName == name) != null) return "Error";
            return null;
        }
        [HttpPost]
        public async Task<ActionResult> AddGenre(Genre genre)
        {
            
            if (!await CheckGenre(genre)) return View();
            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();
            TempData["Adding-success"] = FanfictionErrors.getGenreSuccess(Request.Cookies["lang"]);
            return RedirectToAction("Fanfiction", "Fanfiction");
        }
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> AddGenre()
        {
           
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View();
        }

        public async Task<ActionResult<IEnumerable<ApplicationUser>>> AddFanfic()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
       
            return View(new AddFanfic(await _userManager.GetUserAsync(User), await _context.Fandoms.ToListAsync(),
                await _context.Genres.ToListAsync(), Request.Cookies["lang"]));
        }
        private async Task<bool> CheckFanfic(string name)
        {
            TempData["Fanfic-name"] = await GetFanficMsg(name);
            if (TempData["Fanfic-name"] != null) return false;
            return true;
        }

        private async Task<string> GetFanficMsg(string name)
        {
            if (await _context.Fanfics.FirstOrDefaultAsync(f => f.Name == name) != null) return "Error";
            return null;
        }
        
        [HttpPost]
        public async Task<ActionResult> AddFanfic(AddFanfic fanfic)
        {
         
            if (!await CheckFanfic(fanfic.name)) return View(new AddFanfic(await _userManager.GetUserAsync(User), await _context.Fandoms.ToListAsync(),
                await _context.Genres.ToListAsync(), Request.Cookies["lang"]));

            await _context.Fanfics.AddAsync(new Fanfic(fanfic, _context,  Request.Cookies["lang"], await _userManager.GetUserAsync(User)));
            await _context.SaveChangesAsync();
            TempData["Adding-success"] = FanfictionErrors.getFanficSuccess(Request.Cookies["lang"]);
            return RedirectToAction("Fanfiction", "Fanfiction");
        }
        public async Task<IActionResult> ViewFanfic(int fanficId)
        {
            return View(new FanficModel(await _context.GetFanficAsync(fanficId), Request.Cookies["lang"], (await _userManager.GetUserAsync(User)).Id));
        }
     
        public IActionResult AddChapter(int fanficId, int chapterNumber)
        {
            return View(new Chapter(fanficId, chapterNumber));
        }
        [HttpPost]
        public async Task<IActionResult> AddChapter(Chapter chapter)
        {
            await _context.Chapters.AddAsync(chapter);
            await _context.SaveChangesAsync();
            return RedirectToAction("ViewFanfic", "Fanfiction", new {fanficId = chapter.FanficId});
        }
        public async Task<IActionResult> ReadChapter(int fanficId, int chapterNumber)
        {
            return View(new ChapterRead(fanficId, chapterNumber, _context, 
                (await _userManager.GetUserAsync(User)).Id,
                Request.Cookies["lang"]
                ));
        }
      
        
        [HttpPost]
        public async Task<IActionResult> SetLike(int chapterId)
        {
            
           var like = new Like {chapter = await _context.Chapters.FindAsync(chapterId),user = await _userManager.GetUserAsync(User)};
          
           await _context.Likes.AddAsync(like);
           await _context.SaveChangesAsync();
           return Ok();
        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteLike(int chapterId)
        {
            TempData["ff"] = chapterId;
            var userId = (await _userManager.GetUserAsync(User)).Id;
            var like = await _context.Likes.FirstAsync(l => l.chapterId == chapterId && l.userId == userId);
            _context.Likes.Remove(like);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}