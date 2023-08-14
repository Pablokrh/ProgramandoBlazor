using Ecommerce.WebAssembly;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Ecommerce.WebAssembly.Servicio.Contrato;
using Ecommerce.WebAssembly.Servicio.Implementacion;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5049/api/") });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();




builder.Services.AddScoped<IUsuarioServicio, UsuarioServicio>();
builder.Services.AddScoped<ICategoriaServicio, CategoriaServicio>();
builder.Services.AddScoped<IProductoServicio, ProductoServicio>();
builder.Services.AddScoped<ICarritoServicio, CarritoServicio>();
builder.Services.AddScoped<IVentaServicio, VentaServicio>();
builder.Services.AddScoped<IDashBoardServicio, DashboardServicio>();

builder.Services.AddSweetAlert2();


await builder.Build().RunAsync();




