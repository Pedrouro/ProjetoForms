using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;

namespace ProjetoForms.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task AddAsync(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
