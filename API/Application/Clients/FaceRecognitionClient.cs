using API.Abstractions;

namespace API.Application.Clients
{
    public class FaceRecognitionClient(IConfiguration _configuration) : BaseClient(_configuration)
    {
        public override string ServiceName
        {
            get => "FaceRecognitionService";
        }
    }
}
