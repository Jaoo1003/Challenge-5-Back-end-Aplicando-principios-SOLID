using Challenge_5_.NET.Data.Dtos.Categoria;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Data {
    public interface ICategoriaDao : IQuery<Categoria>, ICommand<CategoriaDto>{
    }
}
