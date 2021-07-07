using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Character
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}