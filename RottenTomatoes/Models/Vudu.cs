using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Vudu
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}