using API.Application.Clients;
using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Responses;

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
