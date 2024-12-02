using API.Application.Requests;
using Newtonsoft.Json;
using RestSharp;

namespace API.Abstractions
{
    public abstract class BaseClient(IConfiguration configuration)
    {
        private readonly IConfiguration _configuration = configuration;

        public virtual string ServiceName { get; set; }

        public string GetMethodByName(string methodName)
        {
            return _configuration.GetSection("MethodUrls").GetSection($"{ServiceName}").GetSection($"{methodName}").Value;
        }

        public string GetServiceUrl(string serviceName)
        {
            return _configuration.GetSection($"ServiceUrls").GetSection($"{serviceName}").Value;
        }

        public async Task<T> PostAsync<T>(string url, PostRequest requestDto) 
        {
            var client = new RestClient(url);

            var request = new RestRequest()
            {
                 Method = Method.Post,
            };

            request.AddJsonBody(requestDto.Body);

            var response = await client.PostAsync(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            else
            {
                throw new Exception("Произошла ошибка во время исполнения post запроса");
            }
        }
    }
}
