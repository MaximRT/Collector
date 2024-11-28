using Application.Enums;
using System;

namespace Application.Interfaces
{
    public interface IService
    {
        Task<IResponse> Send(ServiceDestinationEnum destination, Frame frame);
    }
}
