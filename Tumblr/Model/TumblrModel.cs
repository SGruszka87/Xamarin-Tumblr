using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tumblr.Model
{
    
    public class TumblrModel
    {
        [JsonProperty("title")]
        public string Tytul { get; set; }
        
        [JsonProperty("description")]
        public string Opis { get; set; }       
        
        
        [JsonProperty("name")]
        public string NazwaUzytkownika { get; set; }
        
    }
    public class TumblAvatarModel
    {
        [JsonProperty("Avatar")]
        public string Avatar { get; set; }
    }
}
