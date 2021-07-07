﻿using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Amazon
    {
        [JsonProperty("isPrime")]
        public bool IsPrime { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}