using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuarioVideoAPI.Data.Requests;
using UsuarioVideoAPI.Service;

namespace UsuarioVideoAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase{

        private IAdminUserService _adminUser;

        public LoginController(IAdminUserService adminUser) {
            _adminUser = adminUser;
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request) {
            Result result = _adminUser.Login(request);
            return Ok(result.Successes.First());
        }
    }
}