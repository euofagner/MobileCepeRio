using AppCepeRio.ViewModels;
using AppCepeRio.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AppCepeRio
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter-font.ttf", "MainFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<OnBoardingViewModel>();
            builder.Services.AddTransient<OnBoarding>();
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<App>();

            return builder.Build();
        }
    }
}
