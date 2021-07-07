using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Person
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thumbnailImg")]
        public string ThumbnailImg { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}