using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace fanfiction.Models
{
    public static class UploadPhoto
    {
        private static readonly string clout = "fanfictionteamoff";
        private static readonly string apiKey = "137398413134971";
        private static readonly string apiSecret = "TZhA_4TcnI9TUke8P-6VCDkJ0SM";
        
        public static async Task<string> Upload(IFormFile image)
        {
            ImageUploadParams uploadParams = new ImageUploadParams();

            uploadParams.File = new FileDescription(image.FileName, image.OpenReadStream());

           
            
            var account = new Account(clout, apiKey, apiSecret);

            var cloudinary = new Cloudinary(account);
            var uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult.SecureUrl.AbsoluteUri;
        }
    }
}