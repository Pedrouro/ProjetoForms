using ProjetoForms.DTOs;
using ProjetoForms.Models;

namespace ProjetoForms.Services.Interfaces
{
    public interface IAuthService
    {
        String GerarToken(UsuarioModel usuarioModel);
        Task<ResponseDTO> Login(LoginDTO loginDTO);
    }
}
