using Microsoft.Extensions.Logging;
using Syncfusion.Licensing;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
namespace MauiBlazorClient
{
    public static class MauiProgram
    {
        //MauiBlazorClient.Model
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped<SfDialogService>();
            SyncfusionLicenseProvider.RegisterLicense("MjY2NDMwNkAzMjMyMmUzMDJlMzBMdzdKYXo4dDBrTUhGN081NkRsWGVnRFAvZjZSOFFTd2RXMjZpT21wUUt3PQ==");

            builder.Services.AddSingleton<MyODataServiceContext>();

            builder.Services.AddHttpClient("ODataApiClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:5275/odata/");
            });


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
