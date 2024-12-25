using System.Text.Json.Serialization;

namespace Application.Dto
{
    public class FrameDto
    {
        public required DateTime Timestamp { get; set; }
        public required string Image { get; set; }
        public required int Section { get; set; }
        public required string Event { get; set; }
        
        [JsonPropertyName("frame_uuid")]
        public required Guid FrameId { get; set; }
        
        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
