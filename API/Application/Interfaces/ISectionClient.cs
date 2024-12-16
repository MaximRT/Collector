using API.Application.Requests;

namespace API.Application.Interfaces
{
    public interface ISectionClient
    {
        Task SendPersonsAsync(SectionPostPersonsRequest request);
    }
}
