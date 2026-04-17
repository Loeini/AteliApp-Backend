using AteliApp.Application.Services;
using AteliApp.Domain.Interfaces;
using AteliApp.Infrastructure.Persistence;
using AteliApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ateliapp.db"));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<IOrdemDeServicoRepository, OrdemDeServicoRepository>();
builder.Services.AddScoped<OrdemDeServicoService>();
builder.Services.AddScoped<IMedidasRepository, MedidasRepository>();
builder.Services.AddScoped<MedidasService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();