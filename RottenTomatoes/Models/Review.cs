using System.Collections.Generic;
using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Review
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("creationDate")]
        public object CreationDate { get; set; }

        [JsonProperty("isRotten")]
        public bool IsRotten { get; set; }

        [JsonProperty("quote")]
        public string Quote { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("freshness")]
        public string Freshness { get; set; }

        [JsonProperty("isTop")]
        public bool IsTop { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isFresh")]
        public bool IsFresh { get; set; }

        [JsonProperty("critic")]
        public Critic Critic { get; set; }

        [JsonProperty("publication")]
        public Publication Publication { get; set; }

        [JsonProperty("original_score")]
        public string OriginalScore { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("Reviews")]
        public List<Review> Reviews { get; set; }
    }
}