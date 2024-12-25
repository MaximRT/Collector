using System.Text.Json.Serialization;

namespace Application.Dto
{
    public class ImageAnalysisRequestDto
    {
        public required DateTime TimeStamp { get; set; }
        public required string Image { get; set; }
        public required int Section { get; set; }
        public required string Event { get; set; }
        
        [JsonPropertyName("frame_uuid")]
        public Guid? FrameId { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
