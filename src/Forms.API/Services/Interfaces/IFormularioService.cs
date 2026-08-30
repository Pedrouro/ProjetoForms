using Forms.API.DTOs;

namespace Forms.API.Services.Interfaces
{
    public interface IFormularioService
    {
        Task<ResponseDTO<FormularioResponseDTO>> AddFormularioAsync(CreateFormularioDTO dto);
        Task<FormularioResponseDTO> GetFormularioByIdAsync(int id);
        Task<IEnumerable<FormularioResponseDTO>> GetAllFormulariosAsync();
        Task<ResponseDTO> UpdateFormularioAsync(int id, UpdateFormularioDTO dto);
        Task<ResponseDTO> DeleteFormularioAsync(int id);
    }
}