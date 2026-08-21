using Forms.API.Models;

namespace Forms.API.Repositories.Interfaces
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
