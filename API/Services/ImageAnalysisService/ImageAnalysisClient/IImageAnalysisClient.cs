using Application.Dto;

namespace API.Services.ImageAnalysisClient
{
    public interface IImageAnalysisClient
    {
        Task<T> SendFrameAsync<T>(ImageAnalysisRequestDto dto);
    }
}
