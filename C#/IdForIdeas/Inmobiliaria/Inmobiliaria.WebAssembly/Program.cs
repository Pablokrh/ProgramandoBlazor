using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using Inmobiliaria.WebAssembly;
using Inmobiliaria.WebAssembly.Servicios.Contrato;
using Inmobiliaria.WebAssembly.Servicios.Implementacion;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7264/api/") });

builder.Services.AddBlazoredToast();

builder.Services.AddScoped<IInmobiliariaServicios, InmobiliariaServicios>();
builder.Services.AddScoped<IImagenServicio, ImagenServicio>();


builder.Services.AddSweetAlert2();
builder.Services.AddMudServices();


builder.Services.AddAuthorizationCore();
//builder.Services.AddScoped<AuthenticationStateProvider, AutenticacionExtension>();


await builder.Build().RunAsync();
