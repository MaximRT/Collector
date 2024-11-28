using Newtonsoft.Json;

namespace API.Application.Requests
{
    public class ImageAnalysisRequest
    {
        public DateTime TimeStamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public string Destination { get; set; }

        [JsonProperty("frame_uuid")]
        public string FrameId { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }
    }
}
