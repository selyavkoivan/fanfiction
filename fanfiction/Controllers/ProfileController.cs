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
using fanfiction.Models.Settings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace fanfiction.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext _context;
        public ProfileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._context = context;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
    
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> Profile()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View(await _userManager.GetUserAsync(User));
        }
        

        public async Task<bool> LogoutUser()
        {
            ApplicationUser user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            if (user == null) await _signInManager.SignOutAsync();
            else if (user.Status) await _signInManager.SignOutAsync();
            return (user == null || user.Status);
        }

      
        
        [HttpPost]
        public async Task<ActionResult> UpdateName(string newName, string lang)
        {
            if(await _userManager.FindByNameAsync(newName) != null) TempData["edit-error"] = Errors.getUsernameTaken(lang, newName);
            else
            {
                var user = await _userManager.GetUserAsync(User);
                user.UserName = newName;
                await _userManager.UpdateAsync(user);   
            }
            return Ok();
        }
    
        [HttpPost]
        public async Task<ActionResult> UpdateEmail(string email, string lang)
        {
            if(await  _userManager.FindByEmailAsync(email) != null) TempData["edit-error"] = Errors.getEmailTaken(lang);
            else await SendEmail(email, lang);
            
            return Ok();
        }

        private async Task SendEmail(string email, string lang)
        {
            
            var user = await _userManager.GetUserAsync(User);
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
     
        await EmailService.SendEmailAsync(email, text[0], text[1]);
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
    }
}