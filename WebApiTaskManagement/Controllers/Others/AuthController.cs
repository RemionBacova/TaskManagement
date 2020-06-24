using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTaskManagement.Models;
using WebApiTaskManagement.Models.LoginModels;
using WebApiTaskManagement.Repository.Concrete;

namespace WebApiTaskManagement.Controllers.Others
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private Login_Repository _repository;

        public AuthController(Login_Repository repository)
        {
            this._repository = repository;

        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel l)
        {
            var loginResult = await _repository.Login(l);
            if (loginResult == -1)
            {
                return Unauthorized();
            }
            return Ok();
        }

        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePassword p)
        {
            var changepassResult = await _repository.ChangePassword(p);
            if (changepassResult == -1)
            {
                return Unauthorized();
            }
            return Ok();
        }
    }
}
