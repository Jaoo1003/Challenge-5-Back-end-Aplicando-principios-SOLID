using FluentResults;
using Microsoft.AspNetCore.Identity;
using UsuarioVideoAPI.Data.Requests;

namespace UsuarioVideoAPI.Data.Ef_Core {
    public class LoginEfCore : ILogin {
        private SignInManager<IdentityUser<int>> _signInManager;

        public LoginEfCore(SignInManager<IdentityUser<int>> signInManager) {
            _signInManager = signInManager;
        }

        public Result Login(LoginRequest request) {
            var login = _signInManager.PasswordSignInAsync(request.Username, request.Password, false, false);

            if (login.Result.Succeeded) {
                return Result.Ok().WithSuccess("Login efetuado com Sucesso");
            }
            return Result.Fail("Login falhou");
        }
    }
}
