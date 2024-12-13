using API.Application.Requests;

namespace API.Application.Interfaces
{
    public interface IImageAnalysisClient
    {
        Task<T> SendFrameAsync<T>(ImageAnalysisRequest dto);
    }
}
