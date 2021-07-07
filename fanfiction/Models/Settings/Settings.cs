using System.Collections.Generic;

namespace fanfiction.Models.Settings
{
    public class Settings
    {
        public string lang;
        public string theme;
        public List<string> availableLang;
        public List<string> availableThemes;

        public Settings(string lang, string theme)
        {
            availableThemes = new List<string>();
            availableLang = new List<string>();
            availableLang.AddRange(new string[] {"ru", "en"});
            availableThemes.AddRange(new string[] {"light-theme", "dark-theme"});
            this.lang = lang;
            this.theme = theme;
        }
    }
}