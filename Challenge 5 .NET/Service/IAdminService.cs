using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Service {
    public interface IAdminService {

        IEnumerable<Video> ConsultaVideos();
        IEnumerable<Categoria> ConsultaCategorias();
        Categoria ConsultaCategoriaPorId(int id);
        Video ConsultaVideoPorId(int id);
        void CreateVideo(VideoDto video);
        void UpdateVideo(VideoDto video, int id);
        void DeleteVideo(int id);
        void CreateCategoria(CategoriaDto categoria);
        void UpdateCategoria(CategoriaDto categoria);
        void DeleteCategoria(int id);
    }
}
