using API.Abstractions;

namespace API.Application.Clients
{
    public class AlertClient(IConfiguration _configuration) : BaseClient(_configuration)
    {
        public override string ServiceName
        {
            get => "AlertService";
        }
    }
}
