using CommunityToolkit.Maui;
using ISportApp.Services;
using ISportApp.ViewModels;
using ISportApp.Views;
using Microsoft.Extensions.Logging;

namespace ISportApp
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif


            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<SearchingPlayerPage>();
            builder.Services.AddSingleton<SearchingPlayerViewModel>();
            builder.Services.AddSingleton<SearchingPlayerService>();

            builder.Services.AddSingleton<SearchingEventPage>();
            builder.Services.AddSingleton<SearchingEventViewModel>();
            builder.Services.AddSingleton<SearchingEventService>();

            builder.Services.AddSingleton<PlayerDetails>();
            builder.Services.AddSingleton<PlayerDetailsViewModel>();

            builder.Services.AddSingleton<DatabaseService>();


            return builder.Build();
        }
    }
}
