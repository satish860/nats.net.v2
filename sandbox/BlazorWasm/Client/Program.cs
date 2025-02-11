using NATS.Client.Core;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasm.Client;
using NATS.Client.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddNats(configureOptions: opt => opt with { Url = "ws://localhost:4280", ConnectOptions = ConnectOptions.Default with { Name = "BlazorClient" } });

await builder.Build().RunAsync();
