using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using fanfiction.Models.User;

namespace fanfiction.Models.Fanfiction
{
    public class AddFanficData
    {
        public ApplicationUser Author { get; set; }
        public int FanficId { get; set; }
        public string name { get; set; }
        public string fandomName { get; set; }
        public  string genreName { get; set; }
        public string lang { get; set; }
        public string Description {get;set;}
        public AddFanficData()
        {
            Author = new ApplicationUser();
        }
    }
    public class AddFanfic: AddFanficData
    {
        public List<Fandom> fandoms { get; }
        public List<Genre> genres { get; }
        public string SystemLang { get; }
        public string[] availableLangs { get; }
        
        public AddFanfic(ApplicationUser user, List<Fandom> fandoms, List<Genre> genres, string lang)
        {
            availableLangs = avaliebleSettings.GetLangs();
            Author = user;
            this.fandoms = fandoms;
            this.genres = genres;
            this.SystemLang = lang;
        }
        public AddFanfic(Fanfic fanfic, List<Fandom> fandoms, List<Genre> genres, string lang)
        {
            FanficId = fanfic.FanficId;
            name = fanfic.Name;
            Description = fanfic.Description;
            this.lang = lang;
            
            fandomName = lang == "ru" ? fandoms.First(f => f.FandomId == fanfic.FandomId).RuName :
                fandoms.First(f => f.FandomId == fanfic.FandomId).EnName;
            genreName =  lang == "ru" ? genres.First(f => f.GenreId == fanfic.GenreId).RuName :
                genres.First(f => f.GenreId == fanfic.GenreId).EnName;
      
   
            
            availableLangs = avaliebleSettings.GetLangs();
            Author = new ApplicationUser {Id = fanfic.ApplicationUserId};
            this.fandoms = fandoms;
            this.genres = genres;
            this.SystemLang = lang;
        }
        public AddFanfic()
        {
          Author = new ApplicationUser();
            fandoms = new List<Fandom>();
            genres = new List<Genre>();
            availableLangs = avaliebleSettings.GetLangs();
        }
    }
    
}