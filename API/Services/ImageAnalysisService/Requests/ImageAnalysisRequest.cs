using Newtonsoft.Json;

namespace API.Application.Services.Requests
{
    public class ImageAnalysisRequest
    {
        public DateTime TimeStamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonProperty("frame_uuid")]
        public Guid FrameId { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }
    }
}
