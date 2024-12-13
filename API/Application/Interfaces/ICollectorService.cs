using API.Application.Requests;
using API.Application.Responses;
using API.Domain;

namespace API.Application.Interfaces
{
    public interface ICollectorService
    {
        Task<ImageAnalysisResponse> SendFrameToAnalysService(Frame frame);

        Task<CameraPostResponse> SendStreamAsync(CameraPostRequest request, string toggle);

        Task SendAlertAsync(AlertPostRequest request);
    }
}
