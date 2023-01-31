using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UsuarioVideoAPI.Model;

namespace UsuarioVideoAPI.Service.Handler {
    public class TokenService {

        public Token GenerateToken(IdentityUser<int> usuario, string role) {
            Claim[] userData = new Claim[] {
                new Claim(ClaimTypes.Name, usuario.UserName),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                new Claim(ClaimTypes.Role, role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("@#$Terg354yhy35h87564ae5h%@$%u46j24hqerhqe5u2457656%&@$U246j54q8gsieh426u24JEthn246*@¨&6usgfmn,ryi.jqE%724%"));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims:userData,
                signingCredentials:credentials,
                expires: DateTime.UtcNow.AddHours(8)
                );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return new Token(tokenString);
        }
    }
}