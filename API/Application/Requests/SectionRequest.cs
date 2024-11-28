using Newtonsoft.Json;

namespace API.Application.Requests
{
    public class SectionRequest
    {
        public DateTime TimeStamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public List<Person> Persons { get; set; }
        public string Image { get; set; }

        [JsonProperty("frame_uuid")]
        public string FrameId { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }
    }
}
