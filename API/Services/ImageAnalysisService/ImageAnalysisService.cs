using API.Application.Responses;
using API.Services.ImageAnalysisClient;
using Application.Dto;

namespace API.Services
{
    public class ImageAnalysisService(IImageAnalysisClient client) : IImageAnalysisService
    {
        private readonly IImageAnalysisClient _client = client;

        public async Task<ImageAnalysisResponse> SendFrameAsync(ImageAnalysisRequestDto dto)
        {
            return await _client.SendFrameAsync<ImageAnalysisResponse>(dto);
        }
    }
}
