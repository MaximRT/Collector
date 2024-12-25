using API.Application.Responses;
using API.Requests;

namespace API.Application.Services.FaceRecognitionService.FaceRecognitionClient
{
    public interface IFaceRecognitionClient
    {
        Task<FaceRecognitionSendFrameResponse> SendFrameAsync(FaceRecognitionSendFrameRequest request);
    }
}
