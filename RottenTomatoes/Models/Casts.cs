using System.Collections.Generic;
using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Casts
    {
        [JsonProperty("creators")]
        public List<object> Creators { get; set; }

        [JsonProperty("castItems")]
        public List<CastItem> CastItems { get; set; }

        [JsonProperty("screenwriters")]
        public List<Screenwriter> Screenwriters { get; set; }

        [JsonProperty("directors")]
        public List<Director> Directors { get; set; }

        [JsonProperty("producers")]
        public List<Producer> Producers { get; set; }
    }
}