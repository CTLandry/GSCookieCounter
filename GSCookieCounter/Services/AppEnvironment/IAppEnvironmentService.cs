
using GSCookieCounter.Services.Event;

namespace GSCookieCounter.Services.AppEnvironment
{
    public interface IAppEnvironmentService
    {
        IGSEventService GSEventService { get; }
  
        void UpdateDependencies(bool useMockServices);
    }
}
