
using GSCookieCounter.Services.Event;

namespace GSCookieCounter.Services.AppEnvironment
{
    public class AppEnvironmentService : IAppEnvironmentService
    {
        private readonly IGSEventService _mockGSEventService;
        private readonly IGSEventService _gsEventService;

        public IGSEventService GSEventService { get; private set; }

        public AppEnvironmentService(IGSEventService mockGSEventService, IGSEventService gsEventService)
        {
            _mockGSEventService= mockGSEventService;
            _gsEventService= gsEventService;
        }

        public void UpdateDependencies(bool useMockServices)
        {
            if(useMockServices) 
            {
                GSEventService = _mockGSEventService;
            }
            else
            {
                GSEventService = _gsEventService;
            }
        }
    }
}
