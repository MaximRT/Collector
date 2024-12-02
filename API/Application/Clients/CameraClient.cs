using API.Abstractions;
using API.Application.Requests;
using Newtonsoft.Json;

namespace API.Application.Clients
{
    public class CameraClient(IConfiguration configuration) : BaseClient(configuration)
    {
        public override string ServiceName
        {
            get => "CameraService";
        }

        public async Task<T> PostFramesAsync<T>(CameraPostRequest requestDto, string toggle)
        {
            var baseUrl = GetServiceUrl(ServiceName);
            var methodUrl = GetMethodByName("stream");

            var url = $"{baseUrl}\\{methodUrl}";

            var request = new PostRequest()
            {
                Body = JsonConvert.SerializeObject(requestDto),
                Parameters = new Dictionary<string, string>() { { "toggle", "on" } },
            };

            return await PostAsync<T>(url, request);
        }

    }
}
