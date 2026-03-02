using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;

namespace ProjetoForms.Repositories.Implementations
{
    public class EnvioRepository : IEnvioRepository
    {
        public Task AddAsync(EnvioModel envio)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnvioModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EnvioModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EnvioModel envio)
        {
            throw new NotImplementedException();
        }
    }
}
