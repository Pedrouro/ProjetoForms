using Forms.API.Models;

namespace Forms.API.Repositories.Interfaces
{
    public interface IAlternativaRepository
    {
            Task<AlternativaModel> GetByIdAsync(int id);
            Task<IEnumerable<AlternativaModel>> GetAllAsync();
            Task AddAsync(AlternativaModel alternativa);
            Task UpdateAsync(AlternativaModel alternativa);
            Task DeleteAsync(int id);
    }
}
