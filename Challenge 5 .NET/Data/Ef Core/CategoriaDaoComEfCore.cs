using AutoMapper;
using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Data.Ef_Core {
    public class CategoriaDaoComEfCore : ICategoriaDao{
        private AppDbContext _context;
        private IMapper _mapper;

        public CategoriaDaoComEfCore(AppDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public void Alterar(CategoriaDto dao, int id) {
            Categoria categoria = BuscarPorId(id);
            _mapper.Map(dao, categoria);
            _context.SaveChanges();
        }

        public Categoria BuscarPorId(int id) {
            return _context.Categorias.Find(id);
        }

        public IEnumerable<Categoria> BuscarTodos() {
            return _context.Categorias;
        }

        public void Excluir(int id) {
            Categoria categoria = BuscarPorId(id);
            if (categoria == null) {
                throw new ArgumentNullException("Categoria não encontrada");
            }

            _context.Remove(categoria);
            _context.SaveChanges();
        }

        public void Incluir(CategoriaDto dao) {
            Categoria categoria = _mapper.Map<Categoria>(dao);
            _context.Add(categoria);
            _context.SaveChanges();
        }
    }
}
