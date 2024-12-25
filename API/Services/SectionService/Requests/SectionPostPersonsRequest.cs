using System.Text.Json.Serialization;
using Application.Dto;

namespace API.Services.SectionService.Requests
{
    public class SectionPostPersonsRequest
    {
        public DateTime TimeStamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public List<PersonDto> Persons { get; set; }
        public string? Image { get; set; }

        [JsonPropertyName("frame_id")]
        public Guid? FrameId { get; set; }

        [JsonPropertyName("extra-info")]
        public string? ExtraInfo { get; set; }
    }
}
