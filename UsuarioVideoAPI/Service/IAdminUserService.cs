using FluentResults;
using UsuarioVideoAPI.Data.Dtos;
using UsuarioVideoAPI.Data.Requests;

namespace UsuarioVideoAPI.Service {
    public interface IAdminUserService {
        Result AtivaConta(AtivaContaRequest request);
        Result CadastrarNovoUsuario(UsuarioDto dto);
        Result Login(LoginRequest request);
    }
}  
