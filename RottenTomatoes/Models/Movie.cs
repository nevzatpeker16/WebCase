using System.Collections.Generic;
using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Movie
    {
        [JsonProperty("studio")]
        public string Studio { get; set; }

        [JsonProperty("isInTheaters")]
        public bool IsInTheaters { get; set; }

        [JsonProperty("adjustedScore")]
        public double AdjustedScore { get; set; }

        [JsonProperty("ratingSummary")]
        public RatingSummary RatingSummary { get; set; }

        [JsonProperty("isPlaying")]
        public bool IsPlaying { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vanity")]
        public string Vanity { get; set; }

        [JsonProperty("officialUrl")]
        public string OfficialUrl { get; set; }

        [JsonProperty("advisory")]
        public string Advisory { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("casts")]
        public Casts Casts { get; set; }

        [JsonProperty("mainTrailer")]
        public MainTrailer MainTrailer { get; set; }

        [JsonProperty("isOnDVD")]
        public bool IsOnDVD { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("trackingType")]
        public string TrackingType { get; set; }

        [JsonProperty("genreSet")]
        public List<GenreSet> GenreSet { get; set; }

        [JsonProperty("isUpcoming")]
        public bool IsUpcoming { get; set; }

        [JsonProperty("reviews")]
        public Review Reviews { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("mpaaRating")]
        public string MpaaRating { get; set; }

        [JsonProperty("purchaseOptions")]
        public PurchaseOptions PurchaseOptions { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("videoClips")]
        public VideoClip VideoClips { get; set; }

        [JsonProperty("runningTime")]
        public int RunningTime { get; set; }

        [JsonProperty("runningTimeStr")]
        public string RunningTimeStr { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("photos")]
        public Photo Photos { get; set; }

        [JsonProperty("isOnOpening")]
        public bool IsOnOpening { get; set; }

        [JsonProperty("isLimited")]
        public bool IsLimited { get; set; }

        [JsonProperty("posters")]
        public Posters Posters { get; set; }

        [JsonProperty("ratings")]
        public Ratings Ratings { get; set; }
    }
}