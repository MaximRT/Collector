using API.Abstractions;

namespace API.Application.Clients
{
    public class SectionClient(IConfiguration configuration) : BaseClient(configuration)
    {
        public override string ServiceName
        {
            get => "SectionService";
        }
    }
}
