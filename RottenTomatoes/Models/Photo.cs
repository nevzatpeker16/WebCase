﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class Photo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("photoType")]
        public string PhotoType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("imageId")]
        public int ImageId { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("submittedDate")]
        public string SubmittedDate { get; set; }

        [JsonProperty("submittedBy")]
        public string SubmittedBy { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }
}