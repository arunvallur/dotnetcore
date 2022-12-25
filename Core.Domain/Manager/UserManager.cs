using Core.Data.Contract;
using Core.Domain.Contract;
using Core6.Models;
using Microsoft.Extensions.Configuration;

namespace Core.Domain
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _IUserRepository;
        private readonly IConfiguration _config;
        public UserManager(IUserRepository IUserRepository, IConfiguration config)
        {
            _IUserRepository = IUserRepository;
            _config = config;
        }

        public Response<string> UserValidation(UserLogin userlogin)
        {
            Response<string> response = new Response<string>();                                                                                                                     
            bool result = _IUserRepository.validateUser(userlogin);

            if(result)
            {
                UserDetails UserDetails = new UserDetails(_config);
                response.Data = UserDetails.GenerateToken(userlogin);
            }
            else
            {
                response.Error.Add("User name or pasword is not valide");
            }

            return response;
        }
    }
}
