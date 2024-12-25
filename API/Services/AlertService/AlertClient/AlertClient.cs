using System.Text.Json;
using API.Abstractions;
using API.Application.Interfaces;
using API.Application.Requests;

namespace API.Application.Services.AlertService.AlertClient
{
    public class AlertClient(IConfiguration configuration) : BaseClient(configuration), IAlertClient
    {
        public override string ServiceName => "AlertService";

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
