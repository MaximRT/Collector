using API.Abstractions;
using API.Application.Interfaces;
using API.Application.Responses;
using API.Requests;
using Newtonsoft.Json;

namespace API.Application.Clients
{
    public class FaceRecognitionClient(IConfiguration _configuration) : BaseClient(_configuration), IFaceRecognitionClient
    {
        public override string ServiceName
        {
            get => "FaceRecognitionService";
        }

        public async Task<FaceRecognitionSendFrameResponse> SendFrameAsync(FaceRecognitionSendFrameRequest request)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("frame");

            var body = JsonConvert.SerializeObject(request);

            return await PostAsync<FaceRecognitionSendFrameResponse>(url, methodName, body);
        }
    }
}
