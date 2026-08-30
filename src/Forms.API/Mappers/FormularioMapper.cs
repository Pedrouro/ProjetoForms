using Forms.API.DTOs;
using Forms.API.Models;

namespace Forms.API.Mappers
{
    public static class FormularioMapper
    {
        public static FormularioModel ToModel(this CreateFormularioDTO dto, UsuarioModel criador)
        {
            return new FormularioModel
            {
                Titulo = dto.Titulo,
                Descricao = dto.Descricao,
                DataCriacao = DateTime.UtcNow,
                CriadorId = criador.Id,
                Criador = criador
            };
        }

        public static void ApplyUpdate(this FormularioModel formulario, UpdateFormularioDTO dto)
        {
            formulario.Titulo = dto.Titulo;
            formulario.Descricao = dto.Descricao;
            formulario.Status = dto.Status;
            formulario.DataAtualizacao = DateTime.UtcNow;
        }

        public static FormularioResponseDTO ToResponseDTO(this FormularioModel formulario)
        {
            return new FormularioResponseDTO
            {
                Id = formulario.Id,
                Titulo = formulario.Titulo,
                Descricao = formulario.Descricao,
                DataCriacao = formulario.DataCriacao,
                DataAtualizacao = formulario.DataAtualizacao,
                Status = formulario.Status,
                //CriadorId = formulario.CriadorId,
                //CriadorNome = formulario.Criador.Nome // ajuste conforme o nome real da propriedade em UsuarioModel
            };
        }
    }
}