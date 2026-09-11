using Microsoft.Extensions.Logging;
using ImmigrantAdvisor.Shared.Services;

namespace ImmigrantAdvisor.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Vazirmatn-Regular.ttf", "VazirmatnRegular");
                fonts.AddFont("Vazirmatn-Bold.ttf", "VazirmatnBold");
            });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddScoped<ImmigrationAdvisorService>();
        builder.Services.AddScoped<AppStateService>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
