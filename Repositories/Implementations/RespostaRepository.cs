using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;

namespace ProjetoForms.Repositories.Implementations
{
    public class RespostaRepository : IRespostaRepository
    {
        public Task AddAsync(RespostaModel resposta)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RespostaModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RespostaModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RespostaModel resposta)
        {
            throw new NotImplementedException();
        }
    }
}
