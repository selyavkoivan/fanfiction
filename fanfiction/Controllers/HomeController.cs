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
using Microsoft.AspNetCore.Mvc;



namespace fanfiction.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignIn(string returnUrl = null)
        {
            return View(new UserLog {ReturnUrl = returnUrl});
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();
        }

       

      



        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }
        

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(UserReg userReg)
        {
            var msg = await Task.Run(() => Checker.checkRegistrarion(_userManager, userReg));
            if (msg == string.Empty)
            {
                var user = new ApplicationUser(userReg);
                var result = await _userManager.CreateAsync(user, userReg.Password);
                if (result.Succeeded)
                {

                    SendEmail(user, userReg.lang);


                    return View("DisplayEmail");
                }
                
                  foreach (var i in result.Errors) msg += i.Description;
            }

            TempData["SignUpError"] = msg;
            return View();
        }

        public async void SendEmail(ApplicationUser user, string lang)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Action(
                "ConfirmEmail",
                "Home",
                new {userId = user.Id, code = code},
                protocol: HttpContext.Request.Scheme);
            var text = EmailService.GetEmailConfirmText(lang, callbackUrl); 
            await EmailService.SendEmailAsync(user.Email, text[0], text[1]);
        }
        
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if(result.Succeeded) return RedirectToAction("SignIn", "Home");
            return View("Error");
        }
 
        /* [HttpGet]
       public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }*/



        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(UserLog userLog)
        {
            var user = await _userManager.FindByEmailAsync(userLog.Email);
            var msg = await Task.Run(() => Checker.checkLogin(user, userLog.lang));
            if (msg == string.Empty)
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, userLog.Password, false, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(userLog.ReturnUrl) && Url.IsLocalUrl(userLog.ReturnUrl))
                        return Redirect(userLog.ReturnUrl);
                    user.AuthDate = userLog.GetDate();
                    await _userManager.UpdateAsync(user);
                    return RedirectToAction("Profile", "Profile");
                }
                msg = "Invalid password";
            }

            TempData["SignInError"] = msg;
            return View(userLog);
        }
        
        

        
       
        
    }
}