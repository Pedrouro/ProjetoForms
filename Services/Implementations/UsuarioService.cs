using ProjetoForms.DTOs;
using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;
using ProjetoForms.Services.Interfaces;

namespace ProjetoForms.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _UsuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _UsuarioRepository = usuarioRepository;
        }

        public async Task<ResponseDTO> AddUsuario(UsuarioDTO usuario)
        {
            UsuarioModel user = new UsuarioModel
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                Perfil = usuario.Perfil
            };

            await _UsuarioRepository.AddAsync(user);

            return new ResponseDTO
            {
                Status = true,
                Message = "Usuário adicionado com sucesso."
            };
        }

        public async Task<ResponseDTO> DeleteUsuario(int id)
        {
            await _UsuarioRepository.DeleteAsync(id);

            return new ResponseDTO
            {
                Status = true,
                Message = "Usuário deletado com sucesso."
            };
        }

        public async Task<IEnumerable<UsuarioModel>> GetAllUsuarios()
        {
            return await _UsuarioRepository.GetAllAsync();
        }

        public async Task<UsuarioModel> GetUsuarioById(int id)
        {
            return await _UsuarioRepository.GetByIdAsync(id);
        }

        public async Task<ResponseDTO> UpdateUsuario(UsuarioDTO usuario, int id)
        {
            UsuarioModel usuarioAtualizado = await _UsuarioRepository.GetByIdAsync(id);

            usuarioAtualizado.Nome = usuario.Nome;
            usuarioAtualizado.Email = usuario.Email;
            usuarioAtualizado.Senha = usuario.Senha;
            usuarioAtualizado.Perfil = usuario.Perfil;

            await _UsuarioRepository.UpdateAsync(usuarioAtualizado);

            return new ResponseDTO
            {
                Status = true,
                Message = "Usuário atualizado com sucesso."
            };
        }
    }
}
