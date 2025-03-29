using Microsoft.Extensions.Logging;
using System.Text.Json.Serialization;
//using Windows.ApplicationModel.Activation;

namespace MauiAppMinhasCompras
{
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
                    fonts.AddFont("Quicksand_Bold.otf", "QuicksandBold");
                    fonts.AddFont("Quicksand_Book.otf", "QuicksandBook");
                });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
