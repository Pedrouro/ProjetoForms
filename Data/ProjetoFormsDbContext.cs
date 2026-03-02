using Microsoft.EntityFrameworkCore;
using ProjetoForms.Models;

namespace ProjetoForms.Data
{
    public class ProjetoFormsDbContext : DbContext
    {
        public ProjetoFormsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FormularioModel> Formulario { get; set; }
        public DbSet<PerguntaModel> Pergunta { get; set; }
        public DbSet<RespostaModel> Resposta { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<EnvioModel> Envio { get; set; }
        public DbSet<AlternativaModel> Alternativa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjetoFormsDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
