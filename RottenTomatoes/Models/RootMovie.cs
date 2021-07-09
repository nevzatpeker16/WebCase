using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class RootMovie
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("movies")]
        public Movie[] Movies { get; set; }

        [JsonProperty("links")]
        public TemperaturesLinks Links { get; set; }

        [JsonProperty("link_template")]
        public string LinkTemplate { get; set; }
    }
}