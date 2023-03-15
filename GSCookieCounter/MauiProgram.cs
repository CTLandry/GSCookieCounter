using CommunityToolkit.Maui;
using GSCookieCounter.Services.AppEnvironment;
using GSCookieCounter.Services.Dialog;
using GSCookieCounter.Services.Event;
using GSCookieCounter.Services.Navigation;
using GSCookieCounter.Services.Settings;
using GSCookieCounter.Views;

namespace GSCookieCounter;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    => MauiApp
            .CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureEffects(
                effects =>
                {
                })
            .UseMauiCommunityToolkit()
            .ConfigureFonts(
                fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                    fonts.AddFont("Font_Awesome_5_Free-Regular-400.otf", "FontAwesome-Regular");
                    fonts.AddFont("Font_Awesome_5_Free-Solid-900.otf", "FontAwesome-Solid");
                    fonts.AddFont("Montserrat-Bold.ttf", "Montserrat-Bold");
                    fonts.AddFont("Montserrat-Regular.ttf", "Montserrat-Regular");
                    fonts.AddFont("SourceSansPro-Regular.ttf", "SourceSansPro-Regular");
                    fonts.AddFont("SourceSansPro-Solid.ttf", "SourceSansPro-Solid");
                })
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews()
            .Build();

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder) 
	{
        mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();
        mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();
        mauiAppBuilder.Services.AddSingleton<IDialogService, DialogService>();
        mauiAppBuilder.Services.AddSingleton<IGSEventService, GSEventService>();

        //mauiAppBuilder.Services.AddSingleton<ITheme, Theme>();

        mauiAppBuilder.Services.AddSingleton<IAppEnvironmentService, AppEnvironmentService>(
            serviceProvider =>
            {
               
                var settingsService = serviceProvider.GetService<ISettingsService>();

                var aes =
                    new AppEnvironmentService(
                        new MockGSEventService(), new GSEventService());

                aes.UpdateDependencies(settingsService.UseMocks);
                return aes;
            });

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        //mauiAppBuilder.Services.AddSingleton<MainViewModel>();
        //mauiAppBuilder.Services.AddTransient<CheckoutViewModel>();
       
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
       mauiAppBuilder.Services.AddTransient<EventsView>();
       
        return mauiAppBuilder;
    }
}
