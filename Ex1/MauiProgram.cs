using AdventureWorks.DataLayer;
using AdventureWorks.EntityLayer.EntityClasses;
using AdventureWorks.ViewModelLayer.ViewModelClasses;
using Common.Library.Interfaces;
using Ex1.Views;
using Microsoft.Extensions.Logging;

namespace Ex1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
#if MACCATALYST
OsHelper.SetSwitchText("Yes", "No");
#endif
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddScoped<IRepository<PhoneType>, PhoneTypeRepository>();
//Eliminate Event Handling with Commanding
        builder.Services.AddScoped<IRepository<User>, UserRepository>();
        builder.Services.AddScoped<UserViewModel>();
        builder.Services.AddScoped<UserDetailView>();
        return builder.Build();
    }
}