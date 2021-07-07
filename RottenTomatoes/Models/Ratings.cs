using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Ratings
    {
        [JsonProperty("theaterReleaseDate")]
        public long TheaterReleaseDate { get; set; }

        [JsonProperty("critics_score")]
        public int CriticsScore { get; set; }

        [JsonProperty("critics_rating")]
        public string CriticsRating { get; set; }

        [JsonProperty("dvdReleaseDate")]
        public long DvdReleaseDate { get; set; }

        [JsonProperty("audience_score")]
        public int AudienceScore { get; set; }

        [JsonProperty("audience_rating")]
        public string AudienceRating { get; set; }
    }
}