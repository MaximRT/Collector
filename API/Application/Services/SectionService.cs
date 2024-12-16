using API.Application.Interfaces;
using API.Application.Requests;

namespace API.Application.Services
{
    public class SectionService(ISectionClient sectionClient) : ISectionService
    {
        private readonly ISectionClient _sectionClient = sectionClient;
        public async Task SendPersonsAsync(SectionPostPersonsRequest request)
        {
            await _sectionClient.SendPersonsAsync(request);
        }
    }
}
