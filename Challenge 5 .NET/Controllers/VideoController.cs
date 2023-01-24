using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;
using Challenge_5_.NET.Service;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_5_.NET.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase{

        IAdminService _adminService;

        public VideoController(IAdminService adminService) {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult ConsultaTodosVideos() {
            var videos = _adminService.ConsultaVideos();
            return Ok(videos);
        }

        [HttpGet("{id}")]
        public IActionResult ConsultaVideoPorId(int id) {
            Video video = _adminService.ConsultaVideoPorId(id);
            return Ok(video);
        }

        [HttpGet("categoria/{id}")]
        public IActionResult VideosPorCategoria(int id) {
            var videos = _adminService.ConsultaVideosPorCategoria(id);
            return Ok(videos);
        }

        [HttpGet("busca")]
        public IActionResult VideosPorBusca([FromQuery]string? search = null) {
            var videos = _adminService.ConsultaVideoPorBusca(search);
            return Ok(videos);
        }

        [HttpPost]
        public IActionResult CreateVideo(VideoDto video) {
            _adminService.CreateVideo(video);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaVideo(VideoDto video, int id) {
            _adminService.UpdateVideo(video, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaVideo(int id) {
            _adminService.DeleteVideo(id);
            return NoContent();
        }
    }
}
