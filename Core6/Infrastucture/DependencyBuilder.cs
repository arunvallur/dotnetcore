using Core.Data.Contract;
using Core.Data.Contract.IRepository;
using Core.Data.Repository;
using Core.Domain;
using Core.Domain.Contract;
using Core.Domain.Contract.IManager;
using Core.Domain.Manager;

namespace Core6.Infrastucture
{
    public class DependencyBuilder
    {
        public static void BuildDependency(IServiceCollection services)
        {

            AddScopedDependencies(services);
            AddTransientDependencies(services);
        }

        private static void AddTransientDependencies(IServiceCollection services)
        {
            services.AddTransient<ICustomerManager, CustomerManager>();
            services.AddTransient<IUserManager, UserManager>();
        }

        private static void AddScopedDependencies(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
