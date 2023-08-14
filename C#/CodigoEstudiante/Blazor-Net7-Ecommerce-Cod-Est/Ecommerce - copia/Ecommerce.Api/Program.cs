using Ecommerce.Repositorio.Contrato;
using Ecommerce.Repositorio.DBContext;
using Ecommerce.Repositorio.Implementaci�n;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Utilidades;
using Ecommerce.Servicio.Contrato;
using Ecommerce.Servicio.Implementaci�n;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbecommerceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSql"));
});

//Esto se hace as� porque no se sabe con qu� modelo se va a trabajar
builder.Services.AddTransient(typeof(IGenericoRepositorio<>),typeof(GenericoRepositorio<>));

//Ac� si se sabe con qu� modelo se va a trabajar.
builder.Services.AddScoped<IVentaRepositorio, VentaRepositorio>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
builder.Services.AddScoped<ICategoriaServicio, CategoriaServicio>();
builder.Services.AddScoped<IVentaServicio, VentaServicio>();
builder.Services.AddScoped<IProductoServicio, ProductoServicio>();
builder.Services.AddScoped<IDashboardServicio, DashboardServicio>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("NuevaPolitica", app =>
    {
        app.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    }) ;

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("NuevaPolitica");

app.UseAuthorization();

app.MapControllers();

app.Run();
