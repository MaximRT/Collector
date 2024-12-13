using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Services
{
    public class CameraService(ICameraClient cameraClient) : ICameraService
    {
        private readonly ICameraClient _cameraClient = cameraClient;

        public async Task<CameraPostResponse> PostStreamAsync(CameraPostRequest requestDto, string toggle)
        {
            return await _cameraClient.PostStreamAsync(requestDto, toggle);
        }
    }
}
