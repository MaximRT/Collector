using System.Text.Json.Serialization;
using API.Domain;

namespace API.Application.Services.AlertService.Responses
{
    public class AlertGetAlertDelailsResponse
    {
        [JsonPropertyName("uuid")]
        public Guid? AlertId { get; set; }
        public string Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonPropertyName("known-persons")]
        public IEnumerable<KnownPersons> KnownPersons { get; set; }

        public string? Image { get; set; }

        [JsonPropertyName("frame_uuid")]
        public Guid? FrameId { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
