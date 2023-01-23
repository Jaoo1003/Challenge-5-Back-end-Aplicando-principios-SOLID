namespace Challenge_5_.NET.Data {
    public interface IQuery<T> {
        IEnumerable<T> BuscarTodos();
        T BuscarPorId(int id);
    }
}
