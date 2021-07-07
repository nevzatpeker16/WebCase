using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Publication
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}