using APIVersionado;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Añadir httpclient para hacer httpRequests en los controllers
builder.Services.AddHttpClient();
//Add versioning control
builder.Services.AddApiVersioning(setup =>
{
    setup.DefaultApiVersion = new ApiVersion(1, 0);
    setup.AssumeDefaultVersionWhenUnspecified = true;
    setup.ReportApiVersions = true;

});

//Configurar cómo se quiere documentar

builder.Services.AddVersionedApiExplorer(setup =>
{
    setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//ESTA LINEA DE ABAJO LA DESHABILITO YO: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX    
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); //esta ya viene

//Configurar las opciones
builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();



var app = builder.Build(); //Esta ya viene

//Configurar endpoints para swagger DOcs para cada una de las versiones de la API
var apiVersionDescriptionProvider=app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerEndpoint(
                $"/swagger/{description.GroupName}/swagger.json",
                description.GroupName.ToUpperInvariant());
        };
        //  ESTO ES LO QUE SE OBTIENE: /swagger/v2/swagger.json 
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
