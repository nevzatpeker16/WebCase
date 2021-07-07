using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Audience
    {
        [JsonProperty("numTotal")]
        public int NumTotal { get; set; }

        [JsonProperty("averageScore")]
        public double AverageScore { get; set; }

        [JsonProperty("ratingType")]
        public string RatingType { get; set; }

        [JsonProperty("meterScore")]
        public int MeterScore { get; set; }
    }
}