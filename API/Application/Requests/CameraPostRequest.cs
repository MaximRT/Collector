using Newtonsoft.Json;

namespace API.Application.Requests
{
    public class CameraPostRequest
    {
        public string Destination { get; set; }

        [JsonProperty("max-frames")]
        public int? MaxFrames { get; set; }
        public double? Delay { get; set; }
        
        [JsonProperty("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
