using API.Application.Requests;
using API.Services.SectionService.Requests;

namespace API.Services.SectionService
{
    public interface ISectionService
    {
        Task SendPersonsAsync(SectionPostPersonsRequest request);
    }
}
