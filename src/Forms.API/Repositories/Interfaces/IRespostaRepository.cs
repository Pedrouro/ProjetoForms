using ProjetoForms.Models;

namespace ProjetoForms.Repositories.Interfaces
{
    public interface IRespostaRepository
    {
        Task<RespostaModel> GetByIdAsync(int id);
        Task<IEnumerable<RespostaModel>> GetAllAsync();
        Task AddAsync(RespostaModel resposta);
        Task UpdateAsync(RespostaModel resposta);
        Task DeleteAsync(int id);
    }
}
