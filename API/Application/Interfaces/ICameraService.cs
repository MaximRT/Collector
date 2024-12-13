using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Interfaces
{
    public interface ICameraService
    {
        Task<CameraPostResponse> PostStreamAsync(CameraPostRequest requestDto, string toggle);
    }
}
