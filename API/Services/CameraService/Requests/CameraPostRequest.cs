using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace API.Application.Requests
{
    public class CameraPostRequest
    {
        public string Destination { get; set; }

        [JsonPropertyName("max-frames")]
        public int? MaxFrames { get; set; }
        public double? Delay { get; set; }
        
        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
