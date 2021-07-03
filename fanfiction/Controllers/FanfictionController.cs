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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Mvc;

namespace fanfiction.Controllers
{
    public class FanfictionController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public FanfictionController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> Fanfiction()
        {
            if (await LogoutUser()) return RedirectToAction("SignIn", "Home");
            return View(await _userManager.Users.ToListAsync());
        }
      
        
        public async Task<bool> LogoutUser()
        {
            ApplicationUser user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            if (user == null) await _signInManager.SignOutAsync();
            else if (user.Status) await _signInManager.SignOutAsync();
            return (user == null || user.Status);
        }
    }
}