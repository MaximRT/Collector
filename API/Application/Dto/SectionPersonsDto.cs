using Newtonsoft.Json;

namespace API.Application.Dto
{
    public class SectionPersonsDto
    {
        [JsonProperty("uuid")]
        public Guid Id { get; set; }
        public string Age { get; set; }
        public  string Gender { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonProperty("frame_uuid")]
        public string FrameId { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }
    }
}
