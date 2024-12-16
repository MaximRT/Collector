using API.Application.Responses;
using API.Requests;

namespace API.Application.Interfaces
{
    public interface IFaceRecognitionClient
    {
        Task<FaceRecognitionSendFrameResponse> SendFrameAsync(FaceRecognitionSendFrameRequest request);
    }
}
