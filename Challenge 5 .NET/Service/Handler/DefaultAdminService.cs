using Challenge_5_.NET.Data;
using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Service.Handler {
    public class DefaultAdminService : IAdminService {
        IVideoDao _videoDao;
        ICategoriaDao _categoriaDao;

        public DefaultAdminService(IVideoDao videoDao, ICategoriaDao categoriaDao) {
            _videoDao = videoDao;
            _categoriaDao = categoriaDao;
        }

        public IEnumerable<Video> ConsultaVideos() {
            return _videoDao.BuscarTodos();
        }
        public IEnumerable<Video> ConsultaVideosPorCategoria(int categoriaId) {
            return _videoDao.BuscarTodosPorCategoria(categoriaId);
        }
        public IEnumerable<Video> ConsultaVideoPorBusca(string? search) {
            return _videoDao.BuscarTodosPorParamentro(search);
        }
        public Video ConsultaVideoPorId(int id) {
            return _videoDao.BuscarPorId(id);
        }

        public void UploadVideo(VideoDto dto) {
            _videoDao.Incluir(dto);
        }

        public void UpdateVideo(VideoDto dto, int id) {
            _videoDao.Alterar(dto, id);
        }

        public void DeleteVideo(int id) {
            _videoDao.Excluir(id);
        }
        public void CreateVideo(VideoDto video) {
            _videoDao.Incluir(video);
        }

        public IEnumerable<Categoria> ConsultaCategorias() {
            return _categoriaDao.BuscarTodos();
        }

        public Categoria ConsultaCategoriaPorId(int id) {
            return _categoriaDao.BuscarPorId(id);
        }

        public void CreateCategoria(CategoriaDto categoria) {
            _categoriaDao.Incluir(categoria);
        }

        public void UpdateCategoria(CategoriaDto dto, int id){
            _categoriaDao.Alterar(dto, id);
        }

        public void DeleteCategoria(int id) {
            _categoriaDao.Excluir(id);
        }
    }
}
