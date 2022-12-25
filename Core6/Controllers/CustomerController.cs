using Core.Domain.Contract.IManager;
using Core6.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager _ICustomerManager;
        public CustomerController(ICustomerManager ICustomerManager)
        {
            _ICustomerManager = ICustomerManager;
        }

       // [Authorize]
        [Route("getCustomer")]
        [HttpGet]
        public Response<List<CustomerModel>> getCustomer()
        {
            var result =  _ICustomerManager.getCustomer();
            return result;           
        }

    }
}
