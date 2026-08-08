using ProjetoForms.DTOs;
using ProjetoForms.Models;

namespace ProjetoForms.Services.Interfaces
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
