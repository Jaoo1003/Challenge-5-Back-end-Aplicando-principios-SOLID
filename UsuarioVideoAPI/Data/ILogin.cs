using FluentResults;
using UsuarioVideoAPI.Data.Requests;

namespace UsuarioVideoAPI.Data {
    public interface ILogin {
        Result Login(LoginRequest request);
    }
}
