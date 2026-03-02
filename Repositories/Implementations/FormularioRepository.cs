using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;

namespace ProjetoForms.Repositories.Implementations
{
    public class FormularioRepository : IFormularioRepository
    {
        public Task AddAsync(FormularioModel formulario)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FormularioModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FormularioModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(FormularioModel formulario)
        {
            throw new NotImplementedException();
        }
    }
}
