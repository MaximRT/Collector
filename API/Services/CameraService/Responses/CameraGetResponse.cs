using Newtonsoft.Json;

namespace API.Application.Responses
{
    public class CameraGetResponse
    {
        public int Section { get; set; }
        public string Event { get; set; }
        public string Name { get; set; }
    }
}
