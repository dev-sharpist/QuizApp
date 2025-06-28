using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Xe.AcrylicView;

namespace Quiz
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseAcrylicView()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            NoUnderline();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        private static void NoUnderline()
        {
            // This method is intentionally left empty.
            // It can be used to configure additional settings if needed in the future.

#if ANDROID
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
                if (view is not null)
                {
                    handler.PlatformView.BackgroundTintList =
                    Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
                }
            });
#endif
        }
    }
}
