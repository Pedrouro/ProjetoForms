using Forms.API.Models;

namespace Forms.API.Repositories.Interfaces
{
    public interface IFormularioRepository
    {
        Task<FormularioModel> AddAsync(FormularioModel formulario);
        Task<FormularioModel?> GetByIdAsync(int id);
        Task<IEnumerable<FormularioModel>> GetAllAsync();
        Task UpdateAsync(FormularioModel formulario);
        Task DeleteAsync(FormularioModel formulario);
    }
}
