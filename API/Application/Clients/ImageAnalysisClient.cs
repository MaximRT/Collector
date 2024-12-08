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
            var baseUrl = GetServiceUrl(ServiceName);
            var methodUrl = GetMethodByName("frame");

            var url = $"{baseUrl}/{methodUrl}";

            dto.FrameId = Guid.Parse("7d72b8cc-7f6d-4ccd-af27-2a1a55a38b62");

            var request = new PostRequest()
            {
                 Body = JsonConvert.SerializeObject(dto)
            };

            return await PostAsync<T>(url, request);
        }

    }
}
