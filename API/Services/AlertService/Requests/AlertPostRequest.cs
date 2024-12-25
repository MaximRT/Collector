using System.Text.Json.Serialization;
using Application.Dto;

namespace API.Application.Requests
{
    public class AlertPostRequest
    {
        public DateTime Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonPropertyName("known-persons")]
        public IEnumerable<KnownPersonDto> KnownPersons { get; set; }

        public string? Image { get; set; }

        [JsonPropertyName("frame_uuid")]
        public Guid? FrameId { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
