using BlazorApp.Web;
using BlazorApp.Web.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Mapeamento injeção de dependência para a classe HttpClient
builder.Services.AddScoped(sp => new HttpClient());

//Registrando os serviços da biblioteca Blazored.LocalStorage
builder.Services.AddBlazoredLocalStorage();

//Mapeando injeção de dependência da classe AuthService
builder.Services.AddTransient<AuthService>();

await builder.Build().RunAsync();
