using Forms.API.Models;
using Forms.API.Repositories.Interfaces;

namespace Forms.API.Repositories.Implementations
{
    public class PerguntaRepository : IPerguntaRepository
    {
        public Task AddAsync(PerguntaModel pergunta)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PerguntaModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PerguntaModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PerguntaModel pergunta)
        {
            throw new NotImplementedException();
        }
    }
}
