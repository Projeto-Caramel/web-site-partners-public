using Caramel.Website.Partners;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using MudBlazor.Services;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Configuration.AddJsonFile($"appsettings.{builder.HostEnvironment.Environment}.json", optional: true, reloadOnChange: false);

builder.Services.AddScoped(sp => new HttpService(builder.Configuration["ApiGateway:BaseUrl"], sp.GetService<ISessionStorageService>()));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ApiGateway:BaseUrl"]) });

builder.Services.AddBlazorBootstrap();
builder.Services.AddMudServices();
builder.Services.AddSyncfusionBlazor();

builder.Services.AddSessionStorageServices();

SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXZfeXVVRmlYV0ZxXkE=");

await builder.Build().RunAsync();
