using Forms.API.DTOs;
using Forms.API.Models;

namespace Forms.API.Services.Interfaces
{
    public interface IAuthService
    {
        String GerarToken(UsuarioModel usuarioModel);
        Task<ResponseDTO> Login(LoginDTO loginDTO);
    }
}
