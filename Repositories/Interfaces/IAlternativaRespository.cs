using ProjetoForms.Models;

namespace ProjetoForms.Repositories.Interfaces
{
    public interface IAlternativaRespository
    {
            Task<AlternativaModel> GetByIdAsync(int id);
            Task<IEnumerable<AlternativaModel>> GetAllAsync();
            Task AddAsync(AlternativaModel alternativa);
            Task UpdateAsync(AlternativaModel alternativa);
            Task DeleteAsync(int id);
    }
}
