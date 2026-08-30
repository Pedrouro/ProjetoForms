using Forms.API.DTOs;
using Forms.API.Enums;
using Forms.API.Exceptions;
using Forms.API.Mappers;
using Forms.API.Models;
using Forms.API.Repositories.Interfaces;
using Forms.API.Services.Interfaces;

namespace Forms.API.Services.Implementations
{
    public class FormularioService : IFormularioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IFormularioRepository _formularioRepository;
        private readonly ICurrentUserService _currentUserService;

        public FormularioService(
            IUsuarioRepository usuarioRepository,
            IFormularioRepository formularioRepository,
            ICurrentUserService currentUserService)
        {
            _usuarioRepository = usuarioRepository;
            _formularioRepository = formularioRepository;
            _currentUserService = currentUserService;
        }

        public async Task<ResponseDTO<FormularioResponseDTO>> AddFormularioAsync(CreateFormularioDTO dto)
        {
            int usuarioId = _currentUserService.GetCurrentUserId();
            UsuarioModel usuario = await _usuarioRepository.GetByIdAsync(usuarioId)
                ?? throw new NotFoundException($"Usuário com id {usuarioId} não encontrado.");

            FormularioModel formulario = dto.ToModel(usuario);
            await _formularioRepository.AddAsync(formulario);

            return new ResponseDTO<FormularioResponseDTO>
            {
                Status = true,
                Message = "Formulário criado com sucesso.",
                Data = formulario.ToResponseDTO()
            };
        }

        public async Task<FormularioResponseDTO> GetFormularioByIdAsync(int id)
        {
            FormularioModel? formulario = await _formularioRepository.GetByIdAsync(id);

            if (formulario == null || !UsuarioPodeAcessar(formulario))
                throw new NotFoundException($"Formulário com id {id} não encontrado.");

            return formulario.ToResponseDTO();
        }

        public async Task<IEnumerable<FormularioResponseDTO>> GetAllFormulariosAsync()
        {
            IEnumerable<FormularioModel> formularios = await _formularioRepository.GetAllAsync();
            return formularios.Select(f => f.ToResponseDTO());
        }

        public async Task<ResponseDTO> UpdateFormularioAsync(int id, UpdateFormularioDTO dto)
        {
            FormularioModel? formulario = await _formularioRepository.GetByIdAsync(id);

            if (formulario == null || !UsuarioPodeAcessar(formulario))
                throw new NotFoundException($"Formulário com id {id} não encontrado.");

            formulario.ApplyUpdate(dto);
            await _formularioRepository.UpdateAsync(formulario);

            return new ResponseDTO
            {
                Status = true,
                Message = "Formulário atualizado com sucesso."
            };
        }

        public async Task<ResponseDTO> DeleteFormularioAsync(int id)
        {
            FormularioModel? formulario = await _formularioRepository.GetByIdAsync(id);

            if (formulario == null || !UsuarioPodeAcessar(formulario))
                throw new NotFoundException($"Formulário com id {id} não encontrado.");

            await _formularioRepository.DeleteAsync(formulario);

            return new ResponseDTO
            {
                Status = true,
                Message = "Formulário deletado com sucesso."
            };
        }

        private bool UsuarioPodeAcessar(FormularioModel formulario)
        {
            int currentUsuarioId = _currentUserService.GetCurrentUserId();
            PerfilUsuario currentPerfil = _currentUserService.GetCurrentUserPerfil();

            bool isDono = formulario.CriadorId == currentUsuarioId;
            bool isAdmin = currentPerfil == PerfilUsuario.Administrador;

            return isDono || isAdmin;
        }
    }
}