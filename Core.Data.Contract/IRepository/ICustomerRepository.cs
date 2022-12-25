using Core6.Models;

namespace Core.Data.Contract.IRepository
{
    public interface ICustomerRepository
    {
        Response<List<CustomerModel>> getCustomer();
    }
}
