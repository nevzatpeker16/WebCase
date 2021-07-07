using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class AllCritics
    {
        [JsonProperty("averageRating")]
        public double AverageRating { get; set; }

        [JsonProperty("meterValue")]
        public int MeterValue { get; set; }

        [JsonProperty("numReviews")]
        public int NumReviews { get; set; }

        [JsonProperty("meterClass")]
        public string MeterClass { get; set; }

        [JsonProperty("numRotten")]
        public int NumRotten { get; set; }

        [JsonProperty("hasScore")]
        public bool HasScore { get; set; }

        [JsonProperty("hasReviews")]
        public bool HasReviews { get; set; }

        [JsonProperty("numFresh")]
        public int NumFresh { get; set; }
    }
}