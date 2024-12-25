using API.Domain;
using System.Text.Json.Serialization;

namespace API.Application.Responses
{
    public class ImageAnalysisResponse
    {
        public DateTime Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonPropertyName("known-persons")]
        public List<Person> Persons { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }

        [JsonPropertyName("frame_uuid")]
        public Guid? FrameId { get; set; }
        public string Image { get; set; }
    }
}
