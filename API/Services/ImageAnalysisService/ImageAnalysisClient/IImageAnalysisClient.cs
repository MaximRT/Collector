using API.Application.Requests;
using API.Application.Services.Requests;

namespace API.Application.Services.ImageAnalysisClient
{
    public interface IImageAnalysisClient
    {
        Task<T> SendFrameAsync<T>(ImageAnalysisRequest dto);
    }
}
