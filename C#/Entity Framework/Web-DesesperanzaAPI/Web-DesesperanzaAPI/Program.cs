using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web_DesesperanzaAPI.DataAccess;
using Serilog;



var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((hostbuilderCtx, loggerConf) =>
{
    loggerConf
    .WriteTo.Console()
    .WriteTo.Debug()
    .ReadFrom.Configuration(hostbuilderCtx.Configuration);
});

const string ConnectionName = "BolsaDeDatos";
var connectionString = builder.Configuration.GetConnectionString(ConnectionName);

builder.Services.AddDbContext<UniversityContext>(options=> options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Decirle a la app que use el serilog
app.UseSerilogRequestLogging();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
