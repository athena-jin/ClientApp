using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
namespace MauiBlazorApp
{
    public static class MauiProgram
    {
        //MauiBlazorApp.Model
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
            SyncfusionLicenseProvider.RegisterLicense("MjY2NDMwNkAzMjMyMmUzMDJlMzBMdzdKYXo4dDBrTUhGN081NkRsWGVnRFAvZjZSOFFTd2RXMjZpT21wUUt3PQ==");

            builder.Services.AddSingleton<MyODataServiceContext>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
