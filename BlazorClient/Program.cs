using BlazorClient.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Popups;
using Syncfusion.Licensing;

namespace BlazorClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();

            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddScoped<SfDialogService>();
            SyncfusionLicenseProvider.RegisterLicense("MjY2NDMwNkAzMjMyMmUzMDJlMzBMdzdKYXo4dDBrTUhGN081NkRsWGVnRFAvZjZSOFFTd2RXMjZpT21wUUt3PQ==");
            builder.Services.AddSingleton<MyODataServiceContext>();

            builder.Services.AddHttpClient("ODataApiClient", client =>
            {
                client.BaseAddress = new Uri("http://localhost:5275/odata/");
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}