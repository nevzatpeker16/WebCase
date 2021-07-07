using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Critic
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("thumbnailImage")]
        public string ThumbnailImage { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}