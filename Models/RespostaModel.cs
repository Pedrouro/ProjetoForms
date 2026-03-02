namespace ProjetoForms.Models
{
    public class RespostaModel
    {
        public int Id { get; set; }
        public required PerguntaModel Pergunta { get; set; }
        public AlternativaModel? AlternativaEscolhida { get; set; }
        public string? RespostaTexto { get; set; }
        public required EnvioModel envio { get; set; }

    }
}
