using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Links
    {
        [JsonProperty("review")]
        public string Review { get; set; }

        [JsonProperty("alternate")]
        public string Alternate { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }
}