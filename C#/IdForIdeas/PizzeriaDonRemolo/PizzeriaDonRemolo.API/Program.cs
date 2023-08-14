using Microsoft.EntityFrameworkCore;
using PizzeriaDonRemolo.Repositorio.Contrato;
using PizzeriaDonRemolo.Repositorio.DBContext;
using PizzeriaDonRemolo.Repositorio.Implementacion;
using PizzeriaDonRemolo.Utilidades;
using AutoMapper;
using PizzeriaDonRemolo.Servicio.Contrato;
using PizzeriaDonRemolo.Servicio.Implementación;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PizzeriaDonRemoloContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL"));
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient(typeof(IGenericoRepositorio<>), typeof(GenericoRepositorio<>));

builder.Services.AddScoped<IVentaRepositorio, VentaRepositorio>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));


builder.Services.AddScoped<ICategoriaServicio, CategoriaServicio>();
builder.Services.AddScoped<IVentaServicio, VentaServicio>();
builder.Services.AddScoped<IProductoServicio, ProductoServicio>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("NuevaPolitica2", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("NuevaPolitica2");

app.UseAuthorization();

app.MapControllers();

app.Run();
