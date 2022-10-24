using BlazorDual.BlazorWasm.Client;
using BlazorDual.BlazorWasm.Client.Services;
using BlazorDual.Shared.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastHttpService>();

await builder.Build().RunAsync();
