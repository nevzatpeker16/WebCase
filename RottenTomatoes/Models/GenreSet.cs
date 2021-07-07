using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class GenreSet
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}