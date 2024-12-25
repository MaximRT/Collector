using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Services.CameraService
{
    public interface ICameraService
    {
        Task<CameraPostResponse> PostStreamAsync(CameraPostRequest requestDto, string toggle);
    }
}
