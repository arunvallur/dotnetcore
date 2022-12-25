using AutoMapper;
using Core.Data.Contract.IRepository;
using Core.Data.Models;
using Core6.Models;

namespace Core.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AdventureWorks2019Context _AdventureWorks2019Context;
        public readonly IMapper _mapper;
        public CustomerRepository(AdventureWorks2019Context AdventureWorks2019Context, IMapper mapper)
        {
            _AdventureWorks2019Context = AdventureWorks2019Context;
            _mapper = mapper;
        }

        public Response<List<CustomerModel>> getCustomer()
        {
            Response<List<CustomerModel>> response = new Response<List<CustomerModel>>();

            var DBresult = _AdventureWorks2019Context.Customers.ToList().Take(10);
            var Result = _mapper.Map<List<CustomerModel>>(DBresult);
            response.Data = Result;
            return response;
        }
    }
}
