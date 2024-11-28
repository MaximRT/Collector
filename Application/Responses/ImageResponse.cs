using Application.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class ImageResponse : IResponse
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
