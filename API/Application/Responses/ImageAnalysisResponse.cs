using API.Domain;
using Newtonsoft.Json;

namespace API.Application.Responses
{
    public class ImageAnalysisResponse
    {
        public DateTime Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonProperty("known-persons")]
        public List<Person> Persons { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }

        [JsonProperty("frame_uuid")]
        public Guid FrameId { get; set; }
        public string Image { get; set; }
    }
}
