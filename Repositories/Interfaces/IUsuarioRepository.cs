using ProjetoForms.Models;

namespace ProjetoForms.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioModel> GetByIdAsync(int id);
        Task<IEnumerable<UsuarioModel>> GetAllAsync();
        Task AddAsync(UsuarioModel usuario);
        Task UpdateAsync(UsuarioModel usuario);
        Task DeleteAsync(int id);
    }
}
