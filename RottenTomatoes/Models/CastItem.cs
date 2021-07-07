using System.Collections.Generic;
using Newtonsoft.Json;

namespace RottenTomatoes.Models
{
    public class CastItem
    {
        [JsonProperty("person")]
        public Person Person { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }
    }
}