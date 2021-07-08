namespace fanfiction.Models
{
    public static class avaliebleSettings
    {
        public static string[] GetLangs()
        {
            return new[] {"ru", "en"};
        }
        public static string[] GetThemes()
        {
            return new[] {"light-theme", "dark-theme"};
        }
    }
}