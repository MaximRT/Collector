using Newtonsoft.Json;

namespace API.Domain
{
    public class Frame
    {
        public DateTime Timestamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonProperty("frame_uuid")]
        public Guid FrameId { get; set; }
        public string? Destination { get; set; }
    }
}
