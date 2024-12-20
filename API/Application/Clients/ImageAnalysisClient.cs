﻿using API.Abstractions;
using API.Application.Dto;
using API.Application.Interfaces;
using API.Application.Requests;
using Newtonsoft.Json;

namespace API.Application.Clients
{
    public class ImageAnalysisClient(IConfiguration configuration) : BaseClient(configuration), IImageAnalysisClient
    {
        public override string ServiceName
        {
            get => "ImageAnalysisService";
        }

        public async Task<T> SendFrameAsync<T>(ImageAnalysisRequest request)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("frame");

            //var requestDto = new ImageAnalysisRequestDto()
            //{
            //    TimeStamp = request.TimeStamp,
            //    Image = request.Image,
            //    Section = request.Section,
            //    Event = request.Event,
            //    Destination = GetDestinationUrl("frame"),
            //    FrameId = request?.FrameId,
            //    ExtraInfo = request?.ExtraInfo,
            //};

            var body = JsonConvert.SerializeObject(request);

            return await PostAsync<T>(url, methodName, body);
        }

    }
}
