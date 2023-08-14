using Inmobiliaria.Repositorio.Contrato;
using Inmobiliaria.Repositorio.Implementacion;
using Inmobiliaria.DTO;
using Inmobiliaria.Modelo;
using Inmobiliaria.Utilidades;


using Microsoft.EntityFrameworkCore;
using Inmobiliaria.Servicios.Contrato;
using Inmobiliaria.Servicios.Implementacion;
using Inmobiliaria.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<InmobiliariaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL"));
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("NuevaPolitica", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });

});




builder.Services.AddAutoMapper(typeof(AutomapperProfile));

builder.Services.AddTransient(typeof(IGenericoRepositorio<>), typeof(GenericoRepositorio<>));

builder.Services.AddScoped<IInmuebleServicio, InmuebleServicio>();
builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
builder.Services.AddScoped<IImagenServicio, ImagenServicio>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("NuevaPolitica");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
