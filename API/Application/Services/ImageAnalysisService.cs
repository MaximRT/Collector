using API.Application.Clients;
using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Services
{
    public class ImageAnalysisService(ImageAnalysisClient client)
    {
        private readonly ImageAnalysisClient _client = client;

        public async Task<ImageAnalysisResponse> SendFrameAsync(ImageAnalysisRequest dto)
        {
            return await _client.SendFrameAsync<ImageAnalysisResponse>(dto);
        }
    }
}
