namespace ProjetoForms.Models
{
    public class EnvioModel
    {
        public int Id { get; set; }
        public required FormularioModel Formulario { get; set; }
        public required UsuarioModel Usuario { get; set; }
        public DateTime DataDoEnvio { get; set; }

    }
}
