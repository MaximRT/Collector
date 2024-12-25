using API.Application.Requests;

namespace API.Application.Services.SectionService
{
    public interface ISectionService
    {
        Task SendPersonsAsync(SectionPostPersonsRequest request);
    }
}
