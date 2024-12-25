using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Services.CameraService.CameraClient
{
    public interface ICameraClient
    {
        Task<CameraGetResponse> GetConfigResponseAsync(CancellationToken cancellationToken = default);
        Task<CameraPostResponse> PostStreamAsync(CameraPostRequest requestDto, string toggle);

    }
}
