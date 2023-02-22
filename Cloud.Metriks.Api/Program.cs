using Cloud.Metriks.Api.Dao.Context;
using Cloud.Metriks.Api.Dao.Repository.Empleado;
using Cloud.Metriks.Api.Dao.Repository.Persona;
using Cloud.Metriks.Api.Interface.Repository.Empleado;
using Cloud.Metriks.Api.Interface.Repository.Persona;
using Cloud.Metriks.Api.Interface.Service.Empleado;
using Cloud.Metriks.Api.Interface.Service.Persona;
using Cloud.Metriks.Api.Service.Empleado;
using Cloud.Metriks.Api.Service.Persona;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IPersonaService, PersonaService>();
builder.Services.AddScoped<IEmpleadoService, EmpleadoService>();

builder.Services.AddScoped<IPersonaRepository, PersonaRepository>();
builder.Services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



//Configuracion Entityframework
var progresoConnectionString = builder.Configuration.GetConnectionString("Progreso");
builder.Services.AddDbContext<ProgresoDbContext>(x => x.UseMySql(progresoConnectionString, ServerVersion.AutoDetect(progresoConnectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
