using API.Abstractions;
using API.Application.Enums;

namespace API.Application.Clients
{
    public class ImageAnalysisClient(IConfiguration configuration) : BaseClient(configuration)
    {
        protected override string ServiceName { 
            get => "ImageAnalysis"; 
            set => throw new NotImplementedException(); }

        public override string GetMethodByName()
        {
            throw new NotImplementedException();
        }


        protected override Task<T> SendAsync<T>(T dto, HttpMethodEnum httpMethod)
        {
            throw new NotImplementedException();
        }
    }
}
