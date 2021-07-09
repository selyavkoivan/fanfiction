namespace fanfiction.Models.Fanfiction
{
    public static class FanfictionErrors
    {
        public static string getFandomNameTaken(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Название фандома уже занято";
                case "en": return $"Fandom name already taken";
            }
            return null;
        }
        public static string getGenreNameTaken(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Название жанра уже занято";
                case "en": return $"Genre name already taken";
            }
            return null;
        }
        public static string getFanficNameTaken(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Название фанфика уже занято";
                case "en": return $"Fanfic name already taken";
            }
            return null;
        }
        public static string getFanficSuccess(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Фанфик успешно создан";
                case "en": return $"Fanfic added successfully ";
            }
            return null;
        }
        public static string getFandomSuccess(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Фандом успешно добавлен";
                case "en": return $"Fandom added successfully ";
            }
            return null;
        }
        public static string getGenreSuccess(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Жанр успешно создан";
                case "en": return $"Genre added successfully ";
            }
            return null;
        }
        public static string getFanficEditSuccess(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Фанфик успешно изменен";
                case "en": return $"Fanfic changed successfully ";
            }
            return null;
        }
        public static string getFandomEditSuccess(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Фандом успешно изменен";
                case "en": return $"Fandom changed successfully ";
            }
            return null;
        }
        public static string getGenreEditSuccess(string lang)
        {
            switch (lang)
            {
                case "ru": return $"Жанр успешно изменен";
                case "en": return $"Genre changed successfully ";
            }
            return null;
        }
    }
}