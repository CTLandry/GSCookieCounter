
using System.Collections.ObjectModel;
using GSCookieCounter.Models.Events;

namespace GSCookieCounter.Services.Event
{
    public interface IGSEventService
    {
        Task<ObservableCollection<GSEventService>> LoadCookieEvents();
        Task AddCookieEvent();
        Task DeleteCookieEvent();
        Task EditCookieEvent();
    }
}
