using API.Application.Responses;
using Application.Dto;

namespace API.Services
{
    public interface IImageAnalysisService
    {
        Task<ImageAnalysisResponse> SendFrameAsync(ImageAnalysisRequestDto dto);
    }
}
