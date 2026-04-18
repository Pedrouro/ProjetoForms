using ProjetoForms.DTOs;
using ProjetoForms.Models;

namespace ProjetoForms.Services.Interfaces
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
