using Dcode.CisorFE.Client.Repository;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetAllCustomers;
using System.Net.Http.Json;

namespace Dcode.CisorFE.Client.Implement
{
    public class CustomerServiceClient : ICustomerServiceClient
    {
        private readonly HttpClient _httpClient;

        public CustomerServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<GetAllCustomerModel>> GetAllCustomersAsync()
        {


            try
            {
                return await _httpClient.GetFromJsonAsync<List<GetAllCustomerModel>>("api/customers/lista");
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Handle 404 Not Found
                return new List<GetAllCustomerModel>();
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        /*
         private readonly HttpClient _http;
        public CategoriaService(HttpClient http)
        {
            _http = http;
        }
        public async Task<ResponseDTO<List<CategoriaDTO>>> Lista()
        {
            var result = await _http.GetFromJsonAsync<ResponseDTO<List<CategoriaDTO>>>("api/categoria/Lista");
            return result;
        }
    }
         
         */
    }
}
