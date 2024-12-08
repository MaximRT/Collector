using API.Application.Clients;
using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Services
{
    public class CameraService(CameraClient cameraClient)
    {
        private readonly CameraClient _cameraClient = cameraClient;

        public async Task<CameraPostResponse> SendFrameObjects(CameraPostRequest requestDto, string toggle)
        {
           return await _cameraClient.PostFramesAsync<CameraPostResponse>(requestDto, toggle);
        }
    }
}
