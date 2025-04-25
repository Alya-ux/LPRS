using BlazorDateRangePicker;
using LPRS;
using LPRS.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient for API calls
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddDateRangePicker(config =>
{
    config.Attributes = new Dictionary<String, object>
    {
        {"class","form-control form-control-sm"}
    };
});

// Register VehicleDataService
builder.Services.AddSingleton<VehicleDataService>(); // Use Singleton for static data

await builder.Build().RunAsync();
