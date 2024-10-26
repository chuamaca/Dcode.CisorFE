using Dcode.Pos.Application.DataBase.Customer.Queries.GetAllCustomers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dcode.CisorFE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly IGetAllCustomerQuery _getAllCustomerQuery;

        public CustomersController(IGetAllCustomerQuery getAllCustomerQuery)
        {
            _getAllCustomerQuery = getAllCustomerQuery;
        }

        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<List<GetAllCustomerModel>>> GetAllCustomers()
        {
            var customers = await _getAllCustomerQuery.Execute();
            return Ok(customers);
        }
    }
}
