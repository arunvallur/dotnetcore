using Core.Domain.Contract;
using Core6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _IUserManager;
        public UserController(IUserManager IUserManager)
        {
            _IUserManager = IUserManager;
        }

        [Route("UserLogin")]
        [HttpPost]
        public Response<string> UserLogin(UserLogin userlogin)
        {
            Response<string> result = _IUserManager.UserValidation(userlogin);

            return result;

        }
    }
}
