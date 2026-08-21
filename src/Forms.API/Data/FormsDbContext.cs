using Forms.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoForms.Data
{
    public class FormsDbContext : DbContext
    {
        public FormsDbContext(DbContextOptions options) : base(options)
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FormsDbContext).Assembly);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>()
                .Property(u => u.Perfil)
                .HasConversion<string>();
        }

    }
}
