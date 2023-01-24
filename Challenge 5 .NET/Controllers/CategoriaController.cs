using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Models;
using Challenge_5_.NET.Service;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_5_.NET.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase{

        private IAdminService _adminService;

        public CategoriaController(IAdminService adminService) {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult ConsultaTodasCategorias() {
            var categorias = _adminService.ConsultaCategorias();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public IActionResult ConsultaCategoriaPorId(int id) {
            Categoria categoria = _adminService.ConsultaCategoriaPorId(id);
            return Ok(categoria);
        }

        [HttpPost]
        public IActionResult CreateCategoria(CategoriaDto dto) {
            _adminService.CreateCategoria(dto);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCategoria(CategoriaDto dto, int id) {
            _adminService.UpdateCategoria(dto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCategoria(int id) {
            _adminService.DeleteCategoria(id);
            return NoContent();
        }        
    }
}
