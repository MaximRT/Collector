using API.Application.Requests;
using API.Application.Responses;
using API.Domain;
using API.Requests;

namespace API.Application.Interfaces
{
    public interface ICollectorService
    {
        Task SendFrameToAnalysService(Frame frame);

        Task<CameraPostResponse> SendStreamAsync(CameraPostRequest request, string toggle);

        Task SendAlertAsync(AlertPostRequest request);

        Task SendPersonsAsync(SectionPostPersonsRequest request);
        //Task<FaceRecognitionSendFrameResponse>  SendFrameToFaceRecognitionAsync(FaceRecognitionSendFrameRequest request);

        Task SendFrameToFaceRecognitionAsync(FaceRecognitionSendFrameRequest request);
    }
}
