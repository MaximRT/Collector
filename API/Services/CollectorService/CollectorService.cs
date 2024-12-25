using API.Application.Interfaces;
using API.Application.Requests;
using API.Application.Responses;
using API.Application.Services.CameraService;
using API.Application.Services.Requests;
using API.Application.Services.SectionService;
using API.Domain;
using API.Requests;

namespace API.Application.Services
{
    public class CollectorService
        (
        ICameraService cameraService, IImageAnalysisService imageAnalysisService,
        IAlertService alertService, ISectionService sectionService,
        IFaceRecognitionService faceRecognitionService) : ICollectorService
    {
        private readonly ICameraService _cameraService = cameraService;
        private readonly IImageAnalysisService _imageAnalysisService = imageAnalysisService;
        private readonly IAlertService _alertService = alertService;
        private readonly ISectionService _sectionService = sectionService;
        private readonly IFaceRecognitionService _faceRecognitionService = faceRecognitionService;

        public async Task SendAlertAsync(AlertPostRequest request)
        {
            await _alertService.PostAlertAsync(request);
        }

        public async Task SendFrameToAnalysService(Frame frame)
        {
            var request = new ImageAnalysisRequest()
            {
                TimeStamp = frame.Timestamp,
                Image = frame.Image,
                Section = frame.Section,
                Event = frame.Event,
                FrameId = frame.FrameId,
            };

            var result = await _imageAnalysisService.SendFrameAsync(request);

            var requestToSection = new SectionPostPersonsRequest()
            {
                FrameId = result.FrameId,
                TimeStamp = result.Timestamp,
                Section = result.Section,
                Event = result.Event,
                Image = result.Image,
                Persons = result.Persons,
                ExtraInfo = result.ExtraInfo,
            };

            await _sectionService.SendPersonsAsync(requestToSection);
        }

        public async Task<CameraPostResponse> SendStreamAsync(CameraPostRequest request, string toggle)
        {
            return await _cameraService.PostStreamAsync(request, toggle);
        }

        public async Task SendPersonsAsync(SectionPostPersonsRequest request)
        {
            await _sectionService.SendPersonsAsync(request);
        }

        public async Task SendFrameToFaceRecognitionAsync(FaceRecognitionSendFrameRequest request)
        {
            var result = await _faceRecognitionService.SendFrameAsync(request);

            if (result != null) 
            {
                var requestDto = new AlertPostRequest()
                {
                    Timestamp = result.Timestamp,
                    Section = result.Section,
                    Event = result.Event,
                    KnownPersons = result.KnownPersons,
                    Image = result?.Image,
                    FrameId = result?.FrameId,
                    ExtraInfo = result?.ExtraInfo,
                };

                await _alertService.PostAlertAsync(requestDto);
            }
        }

        //public async Task<FaceRecognitionSendFrameResponse> SendFrameToFaceRecognitionAsync(FaceRecognitionSendFrameRequest request)
        //{
        //    return await _faceRecognitionService.SendFrameAsync(request);
        //}
    }
}
