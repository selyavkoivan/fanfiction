using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using fanfiction.Models;
using fanfiction.Models.User;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;

namespace fanfiction.Controllers
{
    public class AjaxController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly SignInManager<ApplicationUser> _signInManager;

        public AjaxController(IWebHostEnvironment env, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            
            this.env = env;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> UploadImages() // MUST BE "ASYNC"
        {
            return await Task.Run(async () =>
            {
                var dir = env.WebRootPath + "\\uploads";
                try
                {
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir); // make sure there are appropriate permissions on the wwwroot folder
                }
                catch (Exception ex)
                {
                    Response.StatusCode = 500; // SERVER ERROR
                    return ex.Message.ToString();
                }
                var ret = string.Empty; // return value
                for (int i = 0; i < Request.Form.Files.Count; i++)
                {
                    if (Request.Form.Files[i].Length > 0)
                    {
                        if (Request.Form.Files[i].ContentType.ToLower().StartsWith("image/")) // make sure it is an image; can be omitted
                        {
                            if (User != null)
                            {
                                
                                ApplicationUser user = await _userManager.GetUserAsync(User);
                               
                                    string url = await UploadPhoto.Upload(Request.Form.Files[i]);
                                    user.AvatarUrl = url;
                                    await _userManager.UpdateAsync(user);
                            }
                           
                        }
                    }
                }
                return ret;
            });
        }
    }
}