using ProjetoForms.Models;

namespace ProjetoForms.Repositories.Interfaces
{
    public interface IEnvioRepository
    {
            Task<EnvioModel> GetByIdAsync(int id);
            Task<IEnumerable<EnvioModel>> GetAllAsync();
            Task AddAsync(EnvioModel envio);
            Task UpdateAsync(EnvioModel envio);
            Task DeleteAsync(int id);
    }
}
