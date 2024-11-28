using API.Application.Enums;

namespace API.Abstractions
{
    public abstract class BaseClient
    {
        private readonly IConfiguration _configuration;

        protected abstract string ServiceName { get; set; }

        public BaseClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public virtual string GetMethodByName(string serviceName, string methodName) 
        {
            return _configuration[$"MethodUrls:{serviceName}:{methodName}"];
        }

        public virtual string GetServiceUrl(string serviceName)
        {
            return _configuration[$"ServiceUrls:{serviceName}"];
        }

        protected abstract Task<T> SendAsync<T>(T dto, HttpMethodEnum httpMethod) where T: class; 
    }
}
