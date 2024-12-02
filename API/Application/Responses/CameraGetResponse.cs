using Newtonsoft.Json;

namespace API.Application.Responses
{
    public class CameraGetResponse
    {
        public DateTime Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public string Image { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }

        [JsonProperty("frame_uuid")]
        public Guid FrameId { get; set; }
    }
}
