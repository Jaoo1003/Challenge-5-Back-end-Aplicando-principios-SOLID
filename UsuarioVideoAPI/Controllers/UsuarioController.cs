using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using UsuarioVideoAPI.Data.Dtos;
using UsuarioVideoAPI.Data.Requests;
using UsuarioVideoAPI.Model;
using UsuarioVideoAPI.Service;

namespace UsuarioVideoAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase {
        private IAdminUserService _adminUser;

        public UsuarioController(IAdminUserService adminUser) {
            _adminUser = adminUser;
        }


        [HttpPost]
        public IActionResult CadastrarUsuarioNovo(UsuarioDto dto) {
            Result result = _adminUser.CadastrarNovoUsuario(dto);
            if (result.IsFailed) return StatusCode(500);
            return Ok(result.Successes.First());
        }

        [HttpPost("ativa")]
        public IActionResult AtivaConta([FromQuery] AtivaContaRequest request) {
            Result ativa = _adminUser.AtivaConta(request);
            if (ativa.IsFailed) return StatusCode(404);
            return Ok(ativa.Successes.First());
        }
    }
}