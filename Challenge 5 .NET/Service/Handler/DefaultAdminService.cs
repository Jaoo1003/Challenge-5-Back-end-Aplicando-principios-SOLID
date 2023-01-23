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
        public Video ConsultaVideoPorId(int id) {
            return _videoDao.BuscarPorId(id);
        }

        public void UploadVideo(VideoDto video) {
            _videoDao.Incluir(video);
        }

        public void UpdateVideo(UpdateVideoDto video) {
            _videoDao.Alterar(video);
        }

        public void DeleteVideo(int id) {
            _videoDao.Excluir(id);
        }

        public IEnumerable<Categoria> ConsultaCategorias() {
            throw new NotImplementedException();
        }

        public Categoria ConsultaCategoriaPorId(int id) {
            throw new NotImplementedException();
        }

        public void CreateVideo(VideoDto video) {
            throw new NotImplementedException();
        }

        public void CreateCategoria(CategoriaDto categoria) {
            throw new NotImplementedException();
        }

        public void UpdateCategoria(UpdateCategoriaDto categoria) {
            throw new NotImplementedException();
        }

        public void DeleteCategoria(int id) {
            throw new NotImplementedException();
        }
    }
}
