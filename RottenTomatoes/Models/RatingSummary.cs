using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class RatingSummary
    {
        [JsonProperty("topCritics")]
        public TopCritics TopCritics { get; set; }

        [JsonProperty("audience")]
        public Audience Audience { get; set; }

        [JsonProperty("allcount")]
        public int Allcount { get; set; }

        [JsonProperty("freshcount")]
        public int Freshcount { get; set; }

        [JsonProperty("dvdcount")]
        public int Dvdcount { get; set; }

        [JsonProperty("consensus")]
        public string Consensus { get; set; }

        [JsonProperty("allCritics")]
        public AllCritics AllCritics { get; set; }

        [JsonProperty("rottencount")]
        public int Rottencount { get; set; }

        [JsonProperty("topcount")]
        public int Topcount { get; set; }
    }
}