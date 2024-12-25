using API.Application.Interfaces;
using API.Application.Responses;
using API.Application.Services.FaceRecognitionService.FaceRecognitionClient;
using API.Requests;

namespace API.Application.Services.FaceRecognitionService
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
