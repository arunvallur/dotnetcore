using Core6.Models;

namespace Core.Data.Contract
{
    public interface IUserRepository
    {
        bool validateUser(UserLogin userlogin);
    }
}
