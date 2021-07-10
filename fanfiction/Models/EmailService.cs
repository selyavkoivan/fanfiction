using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

namespace EmailApp
{
    public class EmailService
    {
        public static async Task SendEmailAsync(string email, string subject, string message)
        {

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("fanfiction", "fanfictionteamof@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);
                await client.AuthenticateAsync("fanfictionteamof@gmail.com", "40igavumlih");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);


            }

        }

        public static string[] GetEmailConfirmText(string lang, string callbackUrl)
        {
            var email = new string[2];
            switch (lang)
            {
                
            case "ru":
                email[0] = "Подтверждение вашего аккаунта";
                email[1] = $"Подтвердите ваш аккаунт, перейдя по ссылке: <a href='{callbackUrl}'>ссылка</a><br>Благодарим вас за выбор <3";
                break;
            case "en":
                email[0] = "Confirm your account";
                email[1] = $"Confirm your account by clicking on the link: <a href='{callbackUrl}'>link</a><br>Thank you for choosing us <3";
                break;
            }
            return email;
        }
        
        public static string[] GetEmailChangeText(string lang, string callbackUrl)
        {
            var email = new string[2];
            switch (lang)
            {
                
                case "ru":
                    email[0] = "Изменение вашей почты";
                    email[1] = $"Для изменения вашей почты перейдите по ссылке: <a href='{callbackUrl}'>ссылка</a><br>Благодарим вас за выбор <3";
                    break;
                case "en":
                    email[0] = "changing your email";
                    email[1] = $"Change your email by clicking on the link: <a href='{callbackUrl}'>link</a><br>Thank you for choosing us <3";
                    break;
            }
            return email;
        }

        public static string[] GetEmailAlertText(string lang, string newEmail, string adminEmail)
        {
            var email = new string[2];
            switch (lang)
            {
                
                case "ru":
                    email[0] = "Изменение вашей почты";
                    email[1] = $"Подтвердите изменение почты на {newEmail}.<br>Ваша почта была изменена администратором {adminEmail}";
                    break;
                case "en":
                    email[0] = "changing your email";
                    email[1] = $"Confirm the change of mail to {newEmail}.<br>Your mail has been changed by the administrator {adminEmail}";
                    break;
            }
            return email;
        }
        public static bool getAdminByEmail(string email)
        {
            if (email == "selyavkosh2@gmail.com" || email == "fanfictionteamof@gmail.com") return true;
            return false;
        }
    }
}