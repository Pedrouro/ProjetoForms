using Microsoft.AspNetCore.Http.HttpResults;
using ProjetoForms.DTOs;
using ProjetoForms.Models;
using ProjetoForms.Repositories.Interfaces;
using ProjetoForms.Services.Interfaces;

namespace ProjetoForms.Services.Implementations
{
    public class FormularioService : IFormularioService
    {
        
        private readonly IUsuarioRepository _UsuarioRepository;
        private readonly IFormularioRepository _FormularioRepository;

        public FormularioService(IUsuarioRepository usuarioRepository, IFormularioRepository formularioRepository)
        {
            _UsuarioRepository = usuarioRepository;
            _FormularioRepository = formularioRepository;
        }

        public async Task<ResponseDTO> AddFormulario(FormularioDTO formulario)
        {
            UsuarioModel usuario = await _UsuarioRepository.GetByIdAsync(1); // Apenas para testes. Alterar futuramente para pegar o usuário logado

            FormularioModel form = new FormularioModel
            {
                Titulo = formulario.Titulo,
                Descricao = formulario.Descricao,
                DataCriacao = DateTime.Now,
                Criador = usuario
            };

            await _FormularioRepository.AddAsync(form);

            return new ResponseDTO { 
                Status =  true,
                Message = "Formulario criado com sucesso."
            };
        }

        public async Task<ResponseDTO> DeleteFormulario(int id)
        {
            await _FormularioRepository.DeleteAsync(id);
            return new ResponseDTO { 
                Status = true,
                Message = "Formulario deletado com sucesso." 
            };
        }

        public async Task<IEnumerable<FormularioModel>> GetAllFormularios()
        {
            return await _FormularioRepository.GetAllAsync();
        }

        public async Task<FormularioModel> GetFormularioById(int id)
        {
            return await _FormularioRepository.GetByIdAsync(id);
        }

        public async Task<ResponseDTO> UpdateFormulario(FormularioModel formulario, int id)
        {
            FormularioModel formularioAtualizado = await _FormularioRepository.GetByIdAsync(id);

            formularioAtualizado.Titulo = formulario.Titulo;
            formularioAtualizado.Descricao = formulario.Descricao;

            await _FormularioRepository.UpdateAsync(formularioAtualizado);

            return new ResponseDTO
            {
                Status = true,
                Message = "Formulario atualizado com sucesso."
            };
        }
    }
}
