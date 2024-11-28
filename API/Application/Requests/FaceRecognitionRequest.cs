using Newtonsoft.Json;

namespace API.Requests
{
    public class FaceRecognitionRequest
    {
        public DateTime Timestamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public string Destination { get; set; }

        [JsonProperty("frame_uuid")]
        public string FrameId { get; set; }
    }
}
