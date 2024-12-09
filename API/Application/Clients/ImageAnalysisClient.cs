using API.Abstractions;
using API.Application.Requests;
using Newtonsoft.Json;

namespace API.Application.Clients
{
    public class ImageAnalysisClient(IConfiguration configuration) : BaseClient(configuration)
    {
        public override string ServiceName
        {
            get => "ImageAnalysisService";
        }

        public async Task<T> SendFrameAsync<T>(ImageAnalysisRequest dto)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("frame");

            var body = JsonConvert.SerializeObject(dto);

            return await PostAsync<T>(url, methodName, body);
        }

    }
}
