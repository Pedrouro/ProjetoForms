using ProjetoForms.Models;

namespace ProjetoForms.Repositories.Interfaces
{
    public interface IFormularioRepository
    {
            Task<FormularioModel> GetByIdAsync(int id);
            Task<IEnumerable<FormularioModel>> GetAllAsync();
            Task AddAsync(FormularioModel formulario);
            Task UpdateAsync(FormularioModel formulario);
            Task DeleteAsync(int id);
    }
}
