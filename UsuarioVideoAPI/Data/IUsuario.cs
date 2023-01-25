using FluentResults;
using UsuarioVideoAPI.Data.Dtos;
using UsuarioVideoAPI.Data.Requests;

namespace UsuarioVideoAPI.Data {
    public interface IUsuario {
        Result Ativa(AtivaContaRequest request);
        Result Cadastrar(UsuarioDto dto);
    }
}
