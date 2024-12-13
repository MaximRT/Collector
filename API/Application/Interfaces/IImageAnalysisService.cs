using API.Application.Requests;
using API.Application.Responses;

namespace API.Application.Interfaces
{
    public interface IImageAnalysisService
    {
        Task<ImageAnalysisResponse> SendFrameAsync(ImageAnalysisRequest dto);
    }
}
