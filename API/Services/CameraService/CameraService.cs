using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Responses;
using API.Application.Services.CameraService.CameraClient;

namespace API.Application.Services.CameraService
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
