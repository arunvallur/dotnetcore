using Core.Data.Contract;
using Core6.Models;

namespace Core.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool validateUser(UserLogin userlogin)
        {
            return true;
        }
    }
}
