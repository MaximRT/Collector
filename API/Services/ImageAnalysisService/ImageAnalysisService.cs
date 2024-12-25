using API.Application.Requests;
using API.Application.Responses;
using API.Application.Services.ImageAnalysisClient;
using API.Application.Services.Requests;

namespace API.Application.Services
{
    public class ImageAnalysisService(IImageAnalysisClient client) : IImageAnalysisService
    {
        private readonly IImageAnalysisClient _client = client;

        public async Task<ImageAnalysisResponse> SendFrameAsync(ImageAnalysisRequest dto)
        {
            return await _client.SendFrameAsync<ImageAnalysisResponse>(dto);
        }
    }
}
