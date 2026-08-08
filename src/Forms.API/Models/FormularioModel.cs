namespace ProjetoForms.Models
{
    public class FormularioModel
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public required UsuarioModel Criador { get; set; }
    }
}
