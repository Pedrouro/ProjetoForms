namespace ProjetoForms.Models
{
    public class PerguntaModel
    {
        public int Id { get; set; }
        public required String Enunciado { get; set; }
        public required String Tipo { get; set; }
        public required int Ordem { get; set; }
        public required FormularioModel Formulario { get; set; }

    }
}
