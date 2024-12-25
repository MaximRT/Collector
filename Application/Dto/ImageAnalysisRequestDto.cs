using System.Text.Json.Serialization;

namespace API.Application.Dto
{
    public class ImageAnalysisRequestDto
    {
        public DateTime TimeStamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public string? Destination { get; set; }

        [JsonPropertyName("frame_uuid")]
        public Guid? FrameId { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
