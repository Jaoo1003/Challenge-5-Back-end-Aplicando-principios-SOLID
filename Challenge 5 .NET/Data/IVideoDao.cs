using Challenge_5_.NET.Data.Dtos.Video;
using Challenge_5_.NET.Models;

namespace Challenge_5_.NET.Data {
    public interface IVideoDao : IQuery<Video>, ICommand<VideoDto> {
        IEnumerable<Video> BuscarTodosPorCategoria(int categoriaId);
        IEnumerable<Video> BuscarTodosPorParamentro(string? search);
    }
}
