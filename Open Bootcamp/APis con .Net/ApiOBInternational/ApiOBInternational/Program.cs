var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// 1-Localization
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources") ;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//2- Idiomas soportados
var supportedCultures = new[] { "en-US", "es-ES", "fr-FR" }; //Ingles yanqui, español español, franchute de Francia.
var localizationOptinos = new RequestLocalizationOptions()
    .SetDefaultCulture("en-US")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures); //Esto es una vista que devuelve (UI).

//3 - Add Localization to app
app.UseRequestLocalization(localizationOptinos);

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
