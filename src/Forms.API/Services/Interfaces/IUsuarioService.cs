using Forms.API.DTOs;
using Forms.API.Models;

namespace Forms.API.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<ResponseDTO> AddUsuario(UsuarioDTO usuario);
        Task<ResponseDTO> DeleteUsuario(int id);
        Task<IEnumerable<UsuarioModel>> GetAllUsuarios();
        Task<UsuarioModel> GetUsuarioById(int id);
        Task<ResponseDTO> UpdateUsuario(UsuarioDTO usuario, int id);

    }
}
