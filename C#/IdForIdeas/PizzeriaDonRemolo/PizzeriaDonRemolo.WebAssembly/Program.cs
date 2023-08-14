using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


using PizzeriaDonRemolo.WebAssembly;
using PizzeriaDonRemolo.WebAssembly.Servicio.Contrato;
using PizzeriaDonRemolo.WebAssembly.Servicio.Implementacion;
using CurrieTechnologies.Razor.SweetAlert2;
using PizzeriaDonRemolo.DTO;





var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5153/api/") });


builder.Services.AddScoped<ICategoriaServicio, CategoriaServicio>();
builder.Services.AddScoped<IProductoServicio, ProductoServicio>();
//builder.Services.AddScoped<ICarritoServicio, CarritoServicio>();
builder.Services.AddScoped<IVentaServicio, VentaServicio>();

builder.Services.AddBlazoredToast();



builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSweetAlert2();






await builder.Build().RunAsync();
