using Core.Data.Contract.IRepository;
using Core.Domain.Contract.IManager;
using Core6.Models;
using System.Collections.Generic;

namespace Core.Domain.Manager
{
    public class CustomerManager : ICustomerManager
    {
       private readonly ICustomerRepository _ICustomerRepository;
        public CustomerManager(ICustomerRepository ICustomerRepository)
        {
            _ICustomerRepository = ICustomerRepository;
        }
        public Response<List<CustomerModel>> getCustomer()
        {
            var result = _ICustomerRepository.getCustomer();
            return result;
        }
    }
}
