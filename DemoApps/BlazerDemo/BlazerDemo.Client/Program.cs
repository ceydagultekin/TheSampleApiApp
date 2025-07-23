using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(x => new HttpClient { BaseAddress = new Uri("https://localhost:7188") });

await builder.Build().RunAsync();
