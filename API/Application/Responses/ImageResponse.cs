﻿using API.Domain;

namespace API.Responses
{
    public class ImageResponse
    {
        public DateTime Timestamp { get; set; }
        public int Section { get; set; }
        public string Event { get; set; }
        public List<Person>  Persons { get; set; }
        public string Frame_uuid { get; set; }
        public string Image { get; set; }
        public string ResponseType { get; set; }
    }
}
