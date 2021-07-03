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
// AccountController.cs
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        [Route("facebook-login")]
        public IActionResult FacebookLogin()
        {
           // return RedirectToAction("SignUp", "Home");
            var properties = new AuthenticationProperties {RedirectUri = Url.Action("FacebookResponse")};
            return Challenge(properties, FacebookDefaults.AuthenticationScheme);
        }

        [Route("facebook-response")]
        public async Task<IActionResult> FacebookResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var claims = result.Principal.Identities 
                .FirstOrDefault().Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });

            return Json(claims);
        }
    }
}