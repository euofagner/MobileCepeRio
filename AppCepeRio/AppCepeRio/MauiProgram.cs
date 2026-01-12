using AppCepeRio.ViewModels;
using AppCepeRio.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Platform;

namespace AppCepeRio;

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

        builder.Services.AddTransient<OnBoarding>();
        builder.Services.AddTransient<LoginView>();
        builder.Services.AddTransient<HomeView>();
        builder.Services.AddTransient<OnBoardingViewModel>();
        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<App>();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CustomEntry", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif
        });

        return builder.Build();
    }
}
