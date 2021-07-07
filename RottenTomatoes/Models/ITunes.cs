using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class ITunes
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}