using FluentResults;
using UsuarioVideoAPI.Data;
using UsuarioVideoAPI.Data.Dtos;
using UsuarioVideoAPI.Data.Requests;

namespace UsuarioVideoAPI.Service.Handler {
    public class DefaultAdminService : IAdminUserService {
        private IUsuario _usuario;
        private ILogin _login;

        public DefaultAdminService(IUsuario usuario, ILogin login) {
            _usuario = usuario;
            _login = login;
        }

        public Result AtivaConta(AtivaContaRequest request) {
            Result result = _usuario.Ativa(request);
            return result;
        }

        public Result CadastrarNovoUsuario(UsuarioDto dto) {
            Result result = _usuario.Cadastrar(dto);
            return result;
        }

        public Result Login(LoginRequest request) {
            Result result = _login.Login(request);
            return result;
        }
    }
}