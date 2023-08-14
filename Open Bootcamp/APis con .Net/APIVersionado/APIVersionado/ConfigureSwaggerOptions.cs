using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Server.IISIntegration;

namespace APIVersionado
{
    public class ConfigureSwaggerOptions : IConfigureNamedOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public OpenApiInfo CreateVersionInfo(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = "My .Net Api Restful",
                Description = "This is my first Api versioning control",
                Version = description.ApiVersion.ToString(),
                Contact = new OpenApiContact()
                {
                    Email = "pablokrh@gmail.com",
                    Name = "Pablo Krojzl"
                }
            };
            if (description.IsDeprecated)
            {
                info.Description += "This Api version has been deprecatted";
            }
            return info; 
        }

        public void Configure(SwaggerGenOptions options)
        {
            //Add documentación para cada una de las versiones.

            foreach (var description in _provider.ApiVersionDescriptions) {

                options.SwaggerDoc(description.GroupName, CreateVersionInfo(description));
            }
        }

        public void Configure(string? name, SwaggerGenOptions options)
        {
            Configure(options);
        }

       
    }
}
