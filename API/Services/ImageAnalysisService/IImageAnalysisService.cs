using API.Application.Requests;
using API.Application.Responses;
using API.Application.Services.Requests;

namespace API.Application.Services
{
    public interface IImageAnalysisService
    {
        Task<ImageAnalysisResponse> SendFrameAsync(ImageAnalysisRequest dto);
    }
}
