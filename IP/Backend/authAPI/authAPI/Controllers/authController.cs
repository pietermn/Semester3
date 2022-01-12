using System;
using Microsoft.AspNetCore.Mvc;
using authAPI_Interfaces;

namespace authAPI.Controllers
{
    [ApiController]
    [Route("auth")]
    public class authController : ControllerBase
    {
        readonly IAuthContainer _authContainer;
        public authController(IAuthContainer authContainer)
        {
            _authContainer = authContainer;
        }

        [Route("LoginUser"), HttpGet]
        public IActionResult LoginUser(string email, string password)
        {
            return Ok(_authContainer.LoginUser(email, password).Result);
        }
        [Route("CreateUser"), HttpGet]
        public IActionResult CreateUser(string email, string password)
        {
            return Ok(_authContainer.CreateUser(email, password).Result);
        }
    }
}
