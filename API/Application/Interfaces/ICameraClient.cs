using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Interfaces
{
    public interface ICameraClient
    {
        Task<CameraGetResponse> GetConfigResponseAsync(CancellationToken cancellationToken = default);
        //Task<> PostFramesAsync<T>(CameraPostRequest requestDto, string toggle);
    }
}
