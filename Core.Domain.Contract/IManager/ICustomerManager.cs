using Core6.Models;

namespace Core.Domain.Contract.IManager
{
    public interface ICustomerManager
    {
        Response<List<CustomerModel>> getCustomer();
    }
}
