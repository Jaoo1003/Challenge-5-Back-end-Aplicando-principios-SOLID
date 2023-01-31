using FluentResults;
using Microsoft.AspNetCore.Identity;
using UsuarioVideoAPI.Data.Requests;
using UsuarioVideoAPI.Model;
using UsuarioVideoAPI.Service.Handler;

namespace UsuarioVideoAPI.Data.Ef_Core {
    public class LoginEfCore : ILogin {
        private SignInManager<IdentityUser<int>> _signInManager;
        private TokenService _tokenService;

        public LoginEfCore(SignInManager<IdentityUser<int>> signInManager, TokenService tokenService) {
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public Result Login(LoginRequest request) {
            var login = _signInManager.PasswordSignInAsync(request.Username, request.Password, false, false);

            if (login.Result.Succeeded) {

                var user = _signInManager.UserManager.Users.FirstOrDefault(u => u.UserName.ToLower() == request.Username.ToLower());
                Token token = _tokenService.GenerateToken(user, _signInManager.UserManager.GetRolesAsync(user).Result.FirstOrDefault());

                return Result.Ok().WithSuccess(token.Value);
            }
            return Result.Fail("Login falhou");
        }
    }
}
