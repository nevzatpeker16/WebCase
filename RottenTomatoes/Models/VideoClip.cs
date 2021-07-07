using System.Collections.Generic;
using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class VideoClip
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("thumbUrl")]
        public string ThumbUrl { get; set; }

        [JsonProperty("mp4Url")]
        public string Mp4Url { get; set; }

        [JsonProperty("hlsUrl")]
        public string HlsUrl { get; set; }

        [JsonProperty("mainTrailer")]
        public MainTrailer MainTrailer { get; set; }

        [JsonProperty("videoClips")]
        public List<VideoClip> VideoClips { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }
}