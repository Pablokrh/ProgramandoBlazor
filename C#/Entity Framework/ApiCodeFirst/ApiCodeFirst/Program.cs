using BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BolsaDeDatosContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("BolsaDeDatos"));

});


var app = builder.Build();
/*
using (var scope = app.Services.CreateScope())
{
    var context=scope.ServiceProvider.GetRequiredService<BolsaDeDatosContext>();
    context.Database.Migrate();
}
*/

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
