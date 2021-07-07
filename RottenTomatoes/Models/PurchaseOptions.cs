using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class PurchaseOptions
    {
        [JsonProperty("iTunes")]
        public ITunes ITunes { get; set; }

        [JsonProperty("vudu")]
        public Vudu Vudu { get; set; }

        [JsonProperty("netflix")]
        public Netflix Netflix { get; set; }

        [JsonProperty("amazon")]
        public Amazon Amazon { get; set; }
    }
}