namespace Dcode.Pos.Application.DataBase.Customer.Queries.GetAllCustomers
{
    public interface IGetAllCustomerQuery
    {
        Task<List<GetAllCustomerModel>> Execute();
    }
}
