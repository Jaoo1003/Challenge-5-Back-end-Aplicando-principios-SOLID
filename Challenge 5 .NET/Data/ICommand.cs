using Challenge_5_.NET.Data.Dtos.Video;

namespace Challenge_5_.NET.Data {
    public interface ICommand<T> {
        void Incluir(T entity);
        void Excluir(int id);
        void Alterar(T entity, int id);
    }
}
