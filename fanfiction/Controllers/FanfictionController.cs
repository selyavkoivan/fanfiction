using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
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
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> AddFandom(int fandomId)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");
            return View(await _context.Fandoms.FindAsync(fandomId));
        }
      
        
        public async Task<bool> LogoutUser()
        {
            ApplicationUser user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            if (user == null)
            {
                await _signInManager.SignOutAsync();
                return false;
            }

            if (user.Status) await _signInManager.SignOutAsync();
            return (user.Status);
        }
        
       private async Task<bool> CheckFandom(Fandom fandom)
        {
            TempData["Fandom-name-en"] = await GetFandomMsgEn(fandom.EnName);
            TempData["Fandom-name-ru"] = await  GetFandomMsgRu(fandom.RuName);
            if (TempData["Fandom-name-ru"] != null || TempData["Fandom-name-en"] != null) return false;
            return true;
        }
       private async Task<bool> CheckFandomUpdate(Fandom fandom)
       {
           var lastVersion = await _context.Fandoms.AsNoTracking().FirstAsync(f => f.FandomId == fandom.FandomId);
           if(lastVersion.EnName != fandom.EnName) TempData["Fandom-name-en"] = await GetFandomMsgEn(fandom.EnName);
           if(lastVersion.RuName != fandom.RuName) TempData["Fandom-name-ru"] = await  GetFandomMsgRu(fandom.RuName);
           if (TempData["Fandom-name-ru"] != null || TempData["Fandom-name-en"] != null) return false;
           return true;
       }

        private async Task<string> GetFandomMsgEn(string name)
        {
            if (await _context.Fandoms.FirstOrDefaultAsync(f => f.EnName == name) != null) return FanfictionErrors.getFandomNameTaken(Request.Cookies["lang"]);
            return null;
        }
        private async Task<string> GetFandomMsgRu(string name)
        {
            if (await _context.Fandoms.FirstOrDefaultAsync(f => f.RuName == name) != null) return FanfictionErrors.getFandomNameTaken(Request.Cookies["lang"]);
            return null;
        }
        [HttpPost]
        public async Task<ActionResult> AddFandom(Fandom fandom)
        {
            
          
            if(fandom.FandomId != 0)
            {
                if (!await CheckFandomUpdate(fandom)) return View();
                await UpdateFandomInDb(fandom);
            }
            else
            {
                if (!await CheckFandom(fandom)) return View();
                await AddFandomToDb(fandom);
            }
            return RedirectToAction("Fanfiction", "Fanfiction");
        }
        private async Task UpdateFandomInDb(Fandom fandom)
        {
            _context.Fandoms.Update(fandom);
            await _context.SaveChangesAsync(); 
            TempData["Adding-success"] = FanfictionErrors.getFandomEditSuccess(Request.Cookies["lang"]);
        }
        private async Task AddFandomToDb(Fandom fandom)
        {
            await _context.Fandoms.AddAsync(fandom);
            await _context.SaveChangesAsync(); 
            TempData["Adding-success"] = FanfictionErrors.getFandomSuccess(Request.Cookies["lang"]);
        }
        
        private async Task<bool> CheckGenre(Genre genre)
        {
            TempData["Genre-name-en"] = await GetGenreMsgEn(genre.EnName);
            TempData["Genre-name-ru"] = await  GetGenreMsgRu(genre.RuName);
            if (TempData["Genre-name-ru"] != null || TempData["Genre-name-en"] != null) return false;
            return true;
        }
        private async Task<bool> CheckGenreUpdate(Genre genre)
        {
            var lastVersion = await _context.Genres.AsNoTracking().FirstAsync(g => g.GenreId == genre.GenreId);
            
            if(lastVersion.EnName != genre.EnName) TempData["Genre-name-en"] = await GetGenreMsgEn(genre.EnName);
            if(lastVersion.RuName != genre.RuName) TempData["Genre-name-ru"] = await  GetGenreMsgRu(genre.RuName);
        
            if (TempData["Genre-name-ru"] != null || TempData["Genre-name-en"] != null) return false;
            return true;
        }
        private async Task<string> GetGenreMsgEn(string name)
        {
            if (await _context.Genres.FirstOrDefaultAsync(f => f.EnName == name) != null) return FanfictionErrors.getGenreNameTaken(Request.Cookies["lang"]);
            return null;
        }
        private async Task<string> GetGenreMsgRu(string name)
        {
            if (await _context.Genres.FirstOrDefaultAsync(f => f.RuName == name) != null) return FanfictionErrors.getGenreNameTaken(Request.Cookies["lang"]);
            return null;
        }
        [HttpPost]
        public async Task<ActionResult> AddGenre(Genre genre)
        {
            
          
            if(genre.GenreId != 0)
            {
                if (!await CheckGenreUpdate(genre)) return View();
                await UpdateGenreInDb(genre);
            }
            else
            {
                if (!await CheckGenre(genre)) return View();
                await AddGenreToDb(genre); 
            }
        
          
            return RedirectToAction("Fanfiction", "Fanfiction");
        }
        private async Task UpdateGenreInDb(Genre genre)
        {
            _context.Genres.Update(genre);
            await _context.SaveChangesAsync(); 
            TempData["Adding-success"] = FanfictionErrors.getGenreEditSuccess(Request.Cookies["lang"]);
        }
        private async Task AddGenreToDb(Genre genre)
        {
            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync(); 
            TempData["Adding-success"] = FanfictionErrors.getGenreSuccess(Request.Cookies["lang"]);
        }
        public async Task<ActionResult> AddGenre(int genreId)
        {
           
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");
            return View(await _context.Genres.FindAsync(genreId));
            
        }
       

 
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> AddFanfic(string userId, int fanficId)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");
            if (fanficId != 0)
            {
                return View(new AddFanfic(await _context.Fanfics.FindAsync(fanficId) , await _context.Fandoms.ToListAsync(),
                    await _context.Genres.ToListAsync(), Request.Cookies["lang"]));
            }
            if(userId == null) return View(new AddFanfic(await _userManager.GetUserAsync(User), await _context.Fandoms.ToListAsync(),
                await _context.Genres.ToListAsync(), Request.Cookies["lang"]));
            return View(new AddFanfic(await _context.Users.FindAsync(userId), await _context.Fandoms.ToListAsync(),
                await _context.Genres.ToListAsync(), Request.Cookies["lang"]));
        }
        private async Task<bool> CheckFanfic(string name)
        {
            TempData["Fanfic-name"] = await GetFanficMsg(name);
            if (TempData["Fanfic-name"] != null) return false;
            return true;
        }
        private async Task<bool> CheckFanficUpdate(string name, int fanficId)
        {
            TempData["Fanfic-name"] = await GetFanficUpdateMsg(name, fanficId);
            if (TempData["Fanfic-name"] != null) return false;
            return true;
        }
        private async Task<string> GetFanficUpdateMsg(string name, int fanficId)
        {
            if (await _context.Fanfics.FirstOrDefaultAsync(f => f.Name == name && f.FanficId != fanficId) != null) return FanfictionErrors.getFanficNameTaken(Request.Cookies["lang"]);
            return null;
        }
        private async Task<string> GetFanficMsg(string name)
        {
            if (await _context.Fanfics.FirstOrDefaultAsync(f => f.Name == name) != null) return FanfictionErrors.getFanficNameTaken(Request.Cookies["lang"]);
            return null;
        }
        
        [HttpPost]
        public async Task<ActionResult> AddFanfic(AddFanfic fanfic)
        {
            if (fanfic.FanficId != 0)
            {
                if(!await UpdateFanfic(fanfic)) return View(new AddFanfic(await _context.Users.FindAsync(fanfic.Author.Id), await _context.Fandoms.ToListAsync(),
                    await _context.Genres.ToListAsync(), Request.Cookies["lang"]));
                else
                {
                    return RedirectToAction("Fanfiction", "Fanfiction");
                }
            }
            if (!await CheckFanfic(fanfic.name)) return View(new AddFanfic(await _context.Users.FindAsync(fanfic.Author.Id), await _context.Fandoms.ToListAsync(),
                await _context.Genres.ToListAsync(), Request.Cookies["lang"]));

            await _context.Fanfics.AddAsync(new Fanfic(fanfic, _context,  Request.Cookies["lang"], await _context.Users.FindAsync(fanfic.Author.Id)));
            await _context.SaveChangesAsync();
            TempData["Adding-success"] = FanfictionErrors.getFanficSuccess(Request.Cookies["lang"]);
            return RedirectToAction("Fanfiction", "Fanfiction");
        }
        public async Task<bool> UpdateFanfic(AddFanfic fanfic)
        {

            if (!await CheckFanficUpdate(fanfic.name, fanfic.FanficId)) return false;

            var updatedFanfic = new Fanfic(fanfic, _context,  Request.Cookies["lang"], await _context.Users.FindAsync(fanfic.Author.Id));
            updatedFanfic.FanficId = fanfic.FanficId;
            _context.Update(updatedFanfic);
            await _context.SaveChangesAsync();
            TempData["Adding-success"] = FanfictionErrors.getFanficEditSuccess(Request.Cookies["lang"]);
            return true;
        }
        public async Task<IActionResult> ViewFanfic(int fanficId)
        {
            return View(new FanficModel(
                await _context.GetFanficAsync(fanficId), 
                Request.Cookies["lang"], 
                _signInManager.IsSignedIn(User) ? (await _userManager.GetUserAsync(User)).Id : string.Empty,
                await _context.GetCommentsAsync(fanficId),
                await _context.Rates.Where(r => r.fanficId == fanficId).ToListAsync(),
                await Role()
            ));
        }

      
        public async Task<IActionResult> AddChapter(int fanficId, int chapterNumber)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");
            var chapter =
                await _context.Chapters.AsNoTracking().FirstOrDefaultAsync(c => c.FanficId == fanficId && c.ChapterNumber == chapterNumber);
            if (chapter != null)
            {
                return View(chapter);
            }

            return View(new Chapter(fanficId, chapterNumber));
        }
        [HttpPost]
        public async Task<IActionResult> AddChapter(Chapter chapter)
        {
       
          
            if (chapter.ChapterNumber <= await _context.Chapters.CountAsync(c=> c.FanficId == chapter.FanficId))
            {
                
                _context.Chapters.Update(chapter);
            }
            else
            {
                await _context.Chapters.AddAsync(chapter);      
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("ViewFanfic", "Fanfiction", new {fanficId = chapter.FanficId});
        }
        public async Task<IActionResult> ReadChapter(int fanficId, int chapterNumber)
        {
            return View(new ChapterRead(
                fanficId, chapterNumber, _context, 
                _signInManager.IsSignedIn(User) ? (await _userManager.GetUserAsync(User)).Id : null,
                Request.Cookies["lang"],
                await Role()
                ));
        }

        private async Task<bool> Role()
        {
            if (!_signInManager.IsSignedIn(User)) return false;
            var user = await _userManager.GetUserAsync(User);
            return (await _userManager.GetRolesAsync(user)).FirstOrDefault(r => r == "Admin") != null;
        }
        public bool IsSignedIn { get; set; }


        [HttpPost]
        public async Task<IActionResult> SetLike(int chapterId)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");

           var like = new Like {chapter = await _context.Chapters.FindAsync(chapterId),user = await _userManager.GetUserAsync(User)};
          
           await _context.Likes.AddAsync(like);
           await _context.SaveChangesAsync();
           return Ok();
        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteLike(int chapterId)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");

            var userId = (await _userManager.GetUserAsync(User)).Id;
            var like = await _context.Likes.FirstAsync(l => l.chapterId == chapterId && l.userId == userId);
            _context.Likes.Remove(like);
            await _context.SaveChangesAsync();
            return Ok();
        }

        public async Task<ActionResult<IEnumerable<ApplicationUser>>> ViewGenres()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View(new GenresModel
            {
                genres = await _context.Genres.ToListAsync(),
                lang = Request.Cookies["lang"],
                IsSignedIn = _signInManager.IsSignedIn(User)
            });
        }

        public async Task<ActionResult<IEnumerable<ApplicationUser>>> ViewFandoms()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View(new FandomsModel
            {
                fandoms = await _context.Fandoms.ToListAsync(),
                lang = Request.Cookies["lang"],
                IsSignedIn = _signInManager.IsSignedIn(User)
            });
        }
        public async Task<IActionResult> ReadGenre(int genreId)
        {
            return View(new GenreModel 
                {genre = await _context.Genres.FindAsync(genreId), 
                    lang = Request.Cookies["lang"],
                    IsSignedIn = _signInManager.IsSignedIn(User)
                });
        }
        public async Task<IActionResult> ReadFandom(int fandomId)
        {
            return View(new FandomModel
            {
                fandom = await _context.Fandoms.FindAsync(fandomId), 
                lang = Request.Cookies["lang"],
                IsSignedIn = _signInManager.IsSignedIn(User)
            });
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(FanficModel comment)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");

            comment.urComment.AuthorId = (await _userManager.GetUserAsync(User)).Id;
            await _context.Comments.AddAsync(comment.urComment);
            await _context.SaveChangesAsync();
            return RedirectToAction("ViewFanfic", "Fanfiction", new{fanficId = comment.urComment.fanficId}) ;
        }
        public async Task<IActionResult> SetRate(short rateValue, int fanficId)
        {
            if (await LogoutUser() || !_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");

            var myRate = new Rate {Author = await _userManager.GetUserAsync(User), fanficId = fanficId, rate = rateValue};
            await _context.Rates.AddAsync(myRate);
            await _context.SaveChangesAsync();
            return RedirectToAction("ViewFanfic", "Fanfiction", new{fanficId = fanficId}) ;
        }
        
    }
}