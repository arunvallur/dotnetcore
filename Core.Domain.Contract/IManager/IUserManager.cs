using Core6.Models;

namespace Core.Domain.Contract
{
    public interface IUserManager
    {
        Response<string> UserValidation(UserLogin userlogin);
    }
}
