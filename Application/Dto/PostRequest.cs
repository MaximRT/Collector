namespace API.Application.Requests
{
    public class PostRequest
    {
        public string MethodName { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Body { get; set; }
    }
}
