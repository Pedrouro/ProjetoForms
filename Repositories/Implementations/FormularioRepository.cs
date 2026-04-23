using Microsoft.EntityFrameworkCore;
using ProjetoForms.Data;
using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;

namespace ProjetoForms.Repositories.Implementations
{
    public class FormularioRepository : IFormularioRepository
    {
        private readonly FormsDbContext _DbContext;
        public FormularioRepository(FormsDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task AddAsync(FormularioModel formulario)
        {
            await _DbContext.Formulario.AddAsync(formulario);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            FormularioModel formulario = await GetByIdAsync(id);

            if (formulario == null)
                throw new InvalidOperationException();

            _DbContext.Formulario.Remove(formulario);
            await _DbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<FormularioModel>> GetAllAsync()
        {
            return await _DbContext.Formulario.ToListAsync();
            
        }

        public async Task<FormularioModel> GetByIdAsync(int id)
        {
            FormularioModel? formulario = await _DbContext.Formulario.FirstOrDefaultAsync(form => form.Id == id);

            if (formulario == null)
                throw new KeyNotFoundException($"Formulario com o id {id} não encontrado.");
            
            return formulario;
        }

        public async Task UpdateAsync(FormularioModel formulario)
        {
            _DbContext.Formulario.Update(formulario);
            await _DbContext.SaveChangesAsync();
        }
    }
}
