using API.Application.Requests;

namespace API.Application.Interfaces
{
    public interface IAlertService
    {
        Task PostAlertAsync(AlertPostRequest request);
    }
}
