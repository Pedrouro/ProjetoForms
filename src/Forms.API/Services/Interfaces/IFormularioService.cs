using Forms.API.DTOs;
using Forms.API.Models;

namespace Forms.API.Services.Interfaces
{
    public interface IFormularioService
    {
        Task<FormularioModel> GetFormularioById(int id);
        Task<IEnumerable<FormularioModel>> GetAllFormularios();
        Task<ResponseDTO> AddFormulario(FormularioDTO formulario);
        Task<ResponseDTO> DeleteFormulario(int id);
        Task<ResponseDTO> UpdateFormulario(FormularioModel formulario, int id);
    }
}
