namespace ProjetoForms.Models
{
    public class AlternativaModel
    {
        public int Id { get; set; }
        public required string Texto { get; set; }
        public required PerguntaModel Pergunta { get; set; }
    }
}
