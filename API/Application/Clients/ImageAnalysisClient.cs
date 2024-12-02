using API.Abstractions;
using API.Application.Dto;
using API.Application.Enums;
using API.Application.Requests;
using API.Application.Responses;
using Newtonsoft.Json;
using RestSharp;

namespace API.Application.Clients
{
    public class ImageAnalysisClient(IConfiguration configuration) : BaseClient(configuration)
    {
        public override string ServiceName
        {
            get => "ImageAnalysisService";
        }

        //public async Task<ImageAnalysisResponse> SendAsync(ImageAnalysisRequestDto dto, HttpMethodEnum httpMethod)
        //{
        //    switch (httpMethod)
        //    {
        //        case HttpMethodEnum.Get:
        //            return new ImageAnalysisResponse();
        //        case HttpMethodEnum.Post:
        //            {
        //                var request = new PostRequest()
        //                {
        //                    MethodName = GetMethodByName("frame"),
        //                    Parameters = null,
        //                    Headers = null,
        //                    Body = JsonConvert.SerializeObject(dto)
        //                };

        //                return await SendAsync<ImageAnalysisResponse>(request, httpMethod);
        //            }
        //        case HttpMethodEnum.Put:
        //            return new ImageAnalysisResponse();
        //        case HttpMethodEnum.Delete:
        //            return new ImageAnalysisResponse();
        //        default:
        //            return new ImageAnalysisResponse();
        //    }
        //}
    }
}
