using Forms.API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Forms.API.DTOs
{
    public class UpdateFormularioDTO
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(200)]
        public required string Titulo { get; set; }

        [StringLength(1000)]
        public string? Descricao { get; set; }

        public StatusFormulario Status { get; set; }
    }
}