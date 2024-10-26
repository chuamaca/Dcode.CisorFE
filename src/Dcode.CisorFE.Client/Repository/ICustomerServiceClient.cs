using Dcode.Pos.Application.DataBase.Customer.Queries.GetAllCustomers;

namespace Dcode.CisorFE.Client.Repository
{
    public interface ICustomerServiceClient
    {
        Task<List<GetAllCustomerModel>> GetAllCustomersAsync();
    }
}
