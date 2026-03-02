using ProjetoForms.Models;

namespace ProjetoForms.Repositories.Interfaces
{
    public interface IPerguntaRepository
    {
        Task<PerguntaModel> GetByIdAsync(int id);
        Task<IEnumerable<PerguntaModel>> GetAllAsync();
        Task AddAsync(PerguntaModel pergunta);
        Task UpdateAsync(PerguntaModel pergunta);
        Task DeleteAsync(int id);
    }
}
