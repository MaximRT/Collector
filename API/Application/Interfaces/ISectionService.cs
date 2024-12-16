using API.Application.Requests;

namespace API.Application.Interfaces
{
    public interface ISectionService
    {
        Task SendPersonsAsync(SectionPostPersonsRequest request);
    }
}
