using AutoMapper;
using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Data.Ef_Core {
    public class VideoDaoComEfCore : IVideoDao{
        private AppDbContext _context;
        private IMapper _mapper;

        public VideoDaoComEfCore(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public void Alterar(VideoDto video, int id) {
            Video file = BuscarPorId(id);
            _mapper.Map(file, video);
            _context.SaveChanges();
        }

        public Video BuscarPorId(int id) {
            return _context.Videos.Find(id);
        }

        public IEnumerable<Video> BuscarTodos() {
            return _context.Videos.ToList();
        }
        public IEnumerable<Video> BuscarTodosPorCategoria(int categoriaId) {
            return _context.Videos.Where(video => video.CategoriaId == categoriaId);
        }

        public IEnumerable<Video> BuscarTodosPorParamentro(string? search) {
            return _context.Videos.Where(video => video.Titulo.Contains(search));
        }

        public void Excluir(int id) {
            var video = BuscarPorId(id);

            if (video == null) {
                throw new ArgumentNullException("Video não encontrado");
            }
            _context.Remove(video);
            _context.SaveChanges();
        }

        public void Incluir(VideoDto video) {
            Video file = _mapper.Map<Video>(video);
            if (file.CategoriaId == null) {
                file.CategoriaId = 1;
            }
            _context.Videos.Add(file);
            _context.SaveChanges();
        }
    }
}