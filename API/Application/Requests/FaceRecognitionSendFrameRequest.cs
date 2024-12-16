using System.Text.Json.Serialization;

namespace API.Requests
{
    public class FaceRecognitionSendFrameRequest
    {
        public DateTime Timestamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public string? Destination { get; set; }

        [JsonPropertyName("frame_uuid")]
        public string FrameId { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
