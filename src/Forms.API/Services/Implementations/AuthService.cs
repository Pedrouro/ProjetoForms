using Microsoft.IdentityModel.Tokens;
using ProjetoForms.DTOs;
using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;
using ProjetoForms.Services.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BCrypt.Net;

namespace ProjetoForms.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AuthService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public string GerarToken(UsuarioModel usuarioModel)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, usuarioModel.Id.ToString()),
                new Claim(ClaimTypes.Email, usuarioModel.Email),
                new Claim(ClaimTypes.Role, usuarioModel.Perfil.ToString())
            };

            var jwt_key = Environment.GetEnvironmentVariable("JWT_KEY");

            if(string.IsNullOrWhiteSpace(jwt_key))
                throw new Exception("JWT_key não encontrada.");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt_key));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = creds
            };
            
            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateToken(tokenDescriptor);

            return handler.WriteToken(token);
        }

        public async Task<ResponseDTO> Login(LoginDTO loginDTO)
        {
            UsuarioModel? usuario = await _usuarioRepository.GetByEmailAsync(loginDTO.Email);

            if (usuario == null)
                return new ResponseDTO { Status = false, Message = "Credenciais inválidas."};

            if(!BCrypt.Net.BCrypt.Verify(loginDTO.Senha, usuario.Senha))
                return new ResponseDTO { Status = false, Message = "Credenciais inválidas." };

            return new ResponseDTO {Status = true, Message = $"Bearer: {GerarToken(usuario)}" };
        }

    }
}
