using API.Abstractions;
using Application.Dto;
using Newtonsoft.Json;

namespace API.Services.ImageAnalysisClient
{
    public class ImageAnalysisClient(IConfiguration configuration) : BaseClient(configuration), IImageAnalysisClient
    {
        public override string ServiceName => "ImageAnalysisService";

        public async Task<T> SendFrameAsync<T>(ImageAnalysisRequestDto request)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("frame");

            var body = JsonConvert.SerializeObject(request);

            return await PostAsync<T>(url, methodName, body);
        }
    }
}
