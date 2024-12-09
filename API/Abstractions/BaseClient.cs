using API.Application.Requests;
using API.Domain;
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

        public async Task<T> GetAsync<T>(string url, string methodName)
        {
            var client = new RestClient(new Uri(url));

            var request = new RestRequest(methodName, Method.Get);

            request.AddHeader("Content-Type", "application/json");

            var response = await client.ExecuteAsync<T>(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            else
            {
                throw new Exception($"Ошибка {response.StatusCode}: {response.Content}");
            }
        }


        public async Task<T> PostAsync<T>(string url, string methodName, string body) 
        {
            var client = new RestClient(url);

            var request = new RestRequest(methodName, Method.Post);

            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(body);

            var response = await client.ExecuteAsync<T>(request);

            if (response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            else
            {
                throw new Exception($"Ошибка {response.StatusCode}: {response.Content}");
            }
        }
    }
}
