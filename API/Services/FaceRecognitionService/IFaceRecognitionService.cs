using API.Application.Responses;
using API.Requests;

namespace API.Application.Interfaces
{
    public interface IFaceRecognitionService
    {
        //Task<FaceRecognitionSendFrameResponse> SendFrameAsync(FaceRecognitionSendFrameRequest request);

        Task<FaceRecognitionSendFrameResponse> SendFrameAsync(FaceRecognitionSendFrameRequest request);
    }
}
