using API.Application.Requests;
using API.Services.SectionService.Requests;

namespace API.Services.SectionService.SectionClient
{
    public interface ISectionClient
    {
        Task SendPersonsAsync(SectionPostPersonsRequest request);
    }
}
