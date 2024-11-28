
using Domain;

namespace Application.Requests
{
    public class FaceRecognitionRequest
    {
        public DateTime Timestamp { get; set; }
        public string Image { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public string Destination { get; set; }
        public string Frame_uuid { get; set; }
    }
}
