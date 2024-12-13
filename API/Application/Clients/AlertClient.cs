using API.Abstractions;
using API.Application.Interfaces;
using API.Application.Requests;
using System.Text.Json;

namespace API.Application.Clients
{
    public class AlertClient(IConfiguration _configuration) : BaseClient(_configuration), IAlertClient
    {
        public override string ServiceName
        {
            get => "AlertService";
        }

        /// <summary>
        /// Создает новое оповещение
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task PostAlertAsync(AlertPostRequest request)
        {
            var url = GetServiceUrl(ServiceName);
            var method = GetMethodByName("alerts");

            var body = JsonSerializer.Serialize(request);

            await PostAsync<Task>(url, method, body);

        }
    }
}
