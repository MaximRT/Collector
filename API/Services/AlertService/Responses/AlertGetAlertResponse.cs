﻿using Application.Dto;
using Newtonsoft.Json;

namespace API.Application.Services.AlertService.Responses
{
    public class AlertGetAlertResponse
    {
        [JsonProperty("uuid")]
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }

        [JsonProperty("known-persons")]
        public List<KnownPersonDto> KnownPersons { get; set; }

        public string Image { get; set; }

        [JsonProperty("frame_uuid")]
        public string FrameId { get; set; }

        [JsonProperty("extra-info")]
        public string ExtraInfo { get; set; }
    }
}
