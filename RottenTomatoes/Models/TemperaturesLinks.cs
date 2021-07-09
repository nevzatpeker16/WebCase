using System;
using Newtonsoft.Json;

public partial class TemperaturesLinks
{
    [JsonProperty("self")]
    public Uri Self { get; set; }

    [JsonProperty("next")]
    public Uri Next { get; set; }
}