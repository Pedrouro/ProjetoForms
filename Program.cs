using Microsoft.EntityFrameworkCore;
using ProjetoForms.Data;
using ProjetoForms.Repositories.Implementations;
using ProjetoForms.Repositories.Interfaces;
using ProjetoForms.Services.Implementations;
using ProjetoForms.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Repositories

builder.Services.AddScoped<IFormularioRepository, FormularioRepository>();
builder.Services.AddScoped<IPerguntaRepository, PerguntaRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IEnvioRepository, EnvioRepository>();
builder.Services.AddScoped<IRespostaRepository, RespostaRepository>();
builder.Services.AddScoped<IAlternativaRepository, AlternativaRepository>();

// Services

builder.Services.AddScoped<IFormularioService, FormularioService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

// Configuração do DbContext

builder.Services.AddDbContext<FormsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
