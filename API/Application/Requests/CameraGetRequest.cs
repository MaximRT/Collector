namespace API.Application.Requests
{
    public class CameraGetRequest
    {
        public string MethodName { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> Headers { get; set; }
    }
}
