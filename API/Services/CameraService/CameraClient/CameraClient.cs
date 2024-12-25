using API.Abstractions;
using API.Application.Requests;
using API.Application.Responses;
using Newtonsoft.Json;

namespace API.Application.Services.CameraService.CameraClient
{
    public class CameraClient(IConfiguration configuration) : BaseClient(configuration), ICameraClient
    {
        public override string ServiceName
        {
            get => "CameraService";
        }

        public async Task<CameraPostResponse> PostStreamAsync(CameraPostRequest requestDto, string toggle)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("stream");

            var body = JsonConvert.SerializeObject(requestDto);

            var parameters = new Dictionary<string, string>() { { "toggle", "on" } };

            return await PostAsync<CameraPostResponse>(url, methodName, body, parameters);
        }

        public async Task<CameraGetResponse> GetConfigResponseAsync(CancellationToken cancellationToken = default)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("config");

            return await GetAsync<CameraGetResponse>(url, methodName);
        }
    }
}
