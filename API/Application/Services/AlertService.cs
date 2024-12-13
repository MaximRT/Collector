using API.Application.Interfaces;
using API.Application.Requests;

namespace API.Application.Services
{
    public class AlertService(IAlertClient alertClient) : IAlertService
    {
        private readonly IAlertClient _alertClient = alertClient;

        /// <summary>
        /// Создает оповещение
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task PostAlertAsync(AlertPostRequest request)
        {
            await _alertClient.PostAlertAsync(request);
        }
    }
}
