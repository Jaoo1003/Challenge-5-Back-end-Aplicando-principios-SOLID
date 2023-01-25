using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System.Web;
using UsuarioVideoAPI.Data.Dtos;
using UsuarioVideoAPI.Data.Requests;
using UsuarioVideoAPI.Model;

namespace UsuarioVideoAPI.Data.Ef_Core {
    public class UsuarioEfCore : IUsuario {
        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;

        public UsuarioEfCore(IMapper mapper, UserManager<IdentityUser<int>> userManager) {
            _mapper = mapper;
            _userManager = userManager;
        }

        public Result Ativa(AtivaContaRequest request) {
            var user = _userManager.Users.First(u => u.Id == request.UsuarioId);
            var ativa = _userManager.ConfirmEmailAsync(user, request.ActivationCode);

            if (ativa.Result.Succeeded) {
                return Result.Ok().WithSuccess("Conta ativada com Sucesso");
            }
            return Result.Fail("Falha ao ativar conta");
        }

        public Result Cadastrar(UsuarioDto dto) {
            Usuario user = _mapper.Map<Usuario>(dto);
            IdentityUser<int> identityUser = _mapper.Map<IdentityUser<int>>(user);
            Task<IdentityResult> result = _userManager.CreateAsync(identityUser, dto.Password);

            if (result.Result.Succeeded) {
                _userManager.AddToRoleAsync(identityUser, "cadastrado");
                var code = _userManager.GenerateEmailConfirmationTokenAsync(identityUser).Result;
                var encodedCode = HttpUtility.UrlEncode(code);
                return Result.Ok().WithSuccess(encodedCode);
            }
            return Result.Fail("Falha ao cadastrar novo usuário");
        }
    }
}