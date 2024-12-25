using API.Application.Requests;

namespace API.Application.Interfaces
{
    public interface IAlertClient
    {
        /// <summary>
        /// Создает новое оповещение
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task PostAlertAsync(AlertPostRequest request);
    }
}
