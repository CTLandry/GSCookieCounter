using GSCookieCounter.Services.AppEnvironment;
using GSCookieCounter.Services.Navigation;
using GSCookieCounter.Services.Settings;

namespace GSCookieCounter;

public partial class App : Application
{
    private readonly ISettingsService _settingsService;
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly INavigationService _navigationService;

    public App(
		ISettingsService settingsService, 
		IAppEnvironmentService appEnvironmentService,
		INavigationService navigationService)
	{
        _settingsService = settingsService;
        _appEnvironmentService = appEnvironmentService;
        _navigationService = navigationService;

        InitializeComponent();

        InitApp();

		MainPage = new AppShell(navigationService);
	}

    private void InitApp()
    {
       
#if MOCKTEST
        _settingsService.UseMocks = true;
#else
        _settingsService.UseMocks = false;
#endif

        if (!_settingsService.UseMocks)
        {
            _appEnvironmentService.UpdateDependencies(_settingsService.UseMocks);
        }
    }
}
