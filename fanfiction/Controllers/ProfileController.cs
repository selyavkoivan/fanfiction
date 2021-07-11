
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

using fanfiction.Models.User;

using EmailApp;
using fanfiction.Data;
using fanfiction.Models.Fanfiction;
using fanfiction.Models.Settings;


namespace fanfiction.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public ProfileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._context = context;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
    
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> Profile(string userId)
        {
            if (await LogoutUser()) return RedirectToAction("Fanfiction", "Fanfiction");
            if (userId == null)
            {
                if(!_signInManager.IsSignedIn(User)) return RedirectToAction("SignIn", "Home");
                return View(await GetUser());
            }
            return View(await GetUser(userId));
        }
        private async Task<ProfileUser> GetUser()
        {
  
            var user = await _userManager.GetUserAsync(User);
            var fanfics = await _context.GetMyFanfiction(user.Id);
            var adminStatus = (await _userManager.GetRolesAsync(user)).FirstOrDefault(r => r == "Admin") != null;
            return new ProfileUser(user,  Request.Cookies["lang"], _context, 
                user, adminStatus, adminStatus);
        }
        private async Task<ProfileUser> GetUser(string userId)
        {
            var user = await _context.Users.FindAsync(userId);
            var fanfics = await _context.GetMyFanfiction(user.Id);
            var onPageUserIsAdmin = (await _userManager.GetRolesAsync(user)).FirstOrDefault(r => r == "Admin") != null;
            var me = await _userManager.GetUserAsync(User);
            
            if (me != null && (await _userManager.GetRolesAsync(me)).FirstOrDefault(r => r == "Admin") != null) 
            {
                var adminStatus = (await _userManager.GetRolesAsync(me)).FirstOrDefault(r => r == "Admin") != null;

                return new ProfileUser(user,  Request.Cookies["lang"], _context, me, adminStatus, onPageUserIsAdmin);
            }
           
            return new ProfileUser(user,  Request.Cookies["lang"], _context,
                me, false, onPageUserIsAdmin);
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

      
        
        [HttpPost]
        public async Task<ActionResult> UpdateName(string newName, string lang, string userId)
        {
            
            if(await _userManager.FindByNameAsync(newName) != null) TempData["edit-error"] = Errors.getUsernameTaken(lang, newName);
            else
            {
                
                var user = await _context.Users.FindAsync(userId);
                user.UserName = newName;

                _context.Update(user);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }
    
        [HttpPost]
        public async Task<ActionResult> UpdateEmail(string email, string lang, string userId)
        {
            if(await  _userManager.FindByEmailAsync(email) != null) TempData["edit-error"] = Errors.getEmailTaken(lang);
            else await SendEmail(email, lang, userId);
            
            return Ok();
        }

        private async Task SendEmail(string email, string lang, string userId)
        {
            
            var user = await _context.Users.FindAsync(userId);
            var token = await _userManager.GenerateChangeEmailTokenAsync(user, email);
            var callbackUrl = Url.Action(
            "ConfirmEmail",
            "Profile",
            new
            {
                userId = user.Id,
                email = email,
                token = token
            },
            protocol: HttpContext.Request.Scheme);
        var text = EmailService.GetEmailChangeText(lang, callbackUrl);
        var me = await _userManager.GetUserAsync(User);
        await EmailService.SendEmailAsync(email, text[0], text[1]);
        if (me.Id != userId)
        {
            text = EmailService.GetEmailAlertText(lang, email,me.Email );
            await EmailService.SendEmailAsync(user.Email, text[0], text[1]);
        }
       
        }

     

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string email, string token)
        {
            if (userId == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            if(await  _userManager.FindByEmailAsync(email) != null)  return View("Error");
            var result = await _userManager.ChangeEmailAsync(user, email, token);
            if(result.Succeeded) return RedirectToAction("SignIn", "Home");
            return View("Error");
           
        }
        
        public IActionResult Settings()
        {
            return View(new Settings(Request.Cookies["lang"], Request.Cookies["theme"]));
           
        }

        public async Task<IActionResult> AddAdminRights(string userId)
        {
            var user = await _context.Users.FindAsync(userId);
            await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction("Profile", "Profile", new {userId});
        }

        public async Task<IActionResult> Marks()
        {
            if (!_signInManager.IsSignedIn(User) || await LogoutUser()) return RedirectToAction("Fanfiction", "Fanfiction");
            return View(new MarkModel(await _userManager.GetUserAsync(User), _context, Request.Cookies["lang"]));
        }
    }
}