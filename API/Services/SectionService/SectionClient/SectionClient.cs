using API.Abstractions;
using API.Application.Interfaces;
using API.Application.Requests;
using Newtonsoft.Json;

namespace API.Application.Clients
{
    public class SectionClient(IConfiguration configuration) : BaseClient(configuration), ISectionClient
    {
        public override string ServiceName
        {
            get => "SectionService";
        }

        /// <summary>
        /// Отправляет данные о всех людях распознаных на фотографии
        /// </summary>
        /// <param name="request"> Данные о людях </param>
        /// <returns></returns>
        public async Task SendPersonsAsync(SectionPostPersonsRequest request)
        {
            var url = GetServiceUrl(ServiceName);
            var methodName = GetMethodByName("persons");

            var body = JsonConvert.SerializeObject(request);

            await PostAsync<Task>(url, methodName, body);
        }
    }
}
