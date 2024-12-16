using API.Application.Interfaces;
using API.Application.Responses;
using API.Requests;

namespace API.Application.Services
{
    public class FaceRecognitionService(IFaceRecognitionClient faceRecognitionClient) : IFaceRecognitionService
    {
        private readonly IFaceRecognitionClient _faceRecognitionClient = faceRecognitionClient;
        public async Task<FaceRecognitionSendFrameResponse> SendFrameAsync(FaceRecognitionSendFrameRequest request)
        {
            return await _faceRecognitionClient.SendFrameAsync(request);
        }
    }
}
