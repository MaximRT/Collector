using API.Abstractions;
using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Responses;
using Newtonsoft.Json;

namespace API.Application.Clients
{
    public class CameraClient(IConfiguration configuration) : BaseClient(configuration), ICameraClient
    {
        public override string ServiceName
        {
            get => "CameraService";
        }

        //public async Task<T> PostFramesAsync<T>(CameraPostRequest requestDto, string toggle)
        //{
        //    var url = GetServiceUrl(ServiceName);
        //    var methodName = GetMethodByName("stream");

        //    var request = new PostRequest()
        //    {
        //        Body = JsonConvert.SerializeObject(requestDto),
        //        Parameters = new Dictionary<string, string>() { { "toggle", "on" } },
        //    };

        //    return await PostAsync<T>(url, methodName, request);
        //}

        public async Task<CameraGetResponse> GetConfigResponseAsync(CancellationToken cancellationToken = default)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("config");

            return await GetAsync<CameraGetResponse>(url, methodName);
        }
    }
}
