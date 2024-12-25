using System.Text.Json.Serialization;
using Application.Dto;

namespace API.Application.Responses
{
    public class FaceRecognitionSendFrameResponse
    {
        public DateTime Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonPropertyName("known-persons")]
        public List<KnownPersonDto> KnownPersons { get; set; }

        [JsonPropertyName("frame_uuid")]
        public Guid? FrameId { get; set; }
        
        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }

        public string Image { get; set; }
    }
}
