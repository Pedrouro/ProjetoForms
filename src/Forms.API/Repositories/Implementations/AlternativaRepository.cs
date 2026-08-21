using Forms.API.Models;
using Forms.API.Repositories.Interfaces;

namespace Forms.API.Repositories.Implementations
{
    public class AlternativaRepository : IAlternativaRepository
    {
        public Task AddAsync(AlternativaModel alternativa)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlternativaModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AlternativaModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AlternativaModel alternativa)
        {
            throw new NotImplementedException();
        }
    }
}
