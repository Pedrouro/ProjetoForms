using Microsoft.EntityFrameworkCore;
using ProjetoForms.Data;
using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;

namespace ProjetoForms.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly FormsDbContext _DbContext;

        public UsuarioRepository(FormsDbContext dbContext)
        {
            _DbContext = dbContext;
        }   

        public async Task AddAsync(UsuarioModel usuario)
        {
            await _DbContext.Usuario.AddAsync(usuario);
            await _DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            UsuarioModel usuario = await GetByIdAsync(id);

            _DbContext.Usuario.Remove(usuario);
            _DbContext.SaveChanges();
        }

        public async Task<IEnumerable<UsuarioModel>> GetAllAsync()
        {
            return await _DbContext.Usuario.ToListAsync();
        }

        public async Task<UsuarioModel> GetByIdAsync(int id)
        {
            UsuarioModel? usuario = await _DbContext.Usuario.FirstOrDefaultAsync(usuario => usuario.Id == id);

            if (usuario == null)
                throw new KeyNotFoundException($"Usuario com o id {id} não encontrado.");

            return usuario;
        }

        public async Task UpdateAsync(UsuarioModel usuario)
        {
            _DbContext.Usuario.Update(usuario);
            await _DbContext.SaveChangesAsync();
        }
    }
}
