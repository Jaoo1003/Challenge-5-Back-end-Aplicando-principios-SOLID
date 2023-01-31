using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Models;
using Challenge_5_.NET.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Challenge_5_.NET.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase{

        private IAdminService _adminService;

        public CategoriaController(IAdminService adminService) {
            _adminService = adminService;
        }

        [HttpGet]
        [Authorize(Roles = "cadastrado")]
        public IActionResult ConsultaTodasCategorias() {
            var categorias = _adminService.ConsultaCategorias();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "cadastrado")]
        public IActionResult ConsultaCategoriaPorId(int id) {
            Categoria categoria = _adminService.ConsultaCategoriaPorId(id);
            return Ok(categoria);
        }

        [HttpPost]
        [Authorize(Roles = "cadastrado")]
        public IActionResult CreateCategoria(CategoriaDto dto) {
            _adminService.CreateCategoria(dto);
            return NoContent();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "cadastrado")]
        public IActionResult AtualizaCategoria(CategoriaDto dto, int id) {
            _adminService.UpdateCategoria(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "cadastrado")]
        public IActionResult DeletaCategoria(int id) {
            _adminService.DeleteCategoria(id);
            return NoContent();
        }        
    }
}
