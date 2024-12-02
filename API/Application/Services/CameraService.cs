using API.Application.Clients;
using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Services
{
    public class CameraService
    {
        private readonly CameraClient _cameraClient;
        public CameraService(CameraClient cameraClient)
        {
            _cameraClient = cameraClient;
        }

        public async Task<CameraPostResponse> SendFrameObjects(CameraPostRequest requestDto, string toggle)
        {
           return await _cameraClient.PostFramesAsync<CameraPostResponse>(requestDto, toggle);
        }
    }
}
