using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Netflix
    {
        [JsonProperty("streamingId")]
        public string StreamingId { get; set; }
    }
}