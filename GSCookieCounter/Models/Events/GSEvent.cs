using SQLite;

namespace GSCookieCounter.Models.Events
{
    public class GSEvent
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }

        public GSEvent(string eventName, DateTime eventDate)
        {
            EventName = eventName;
            EventDate = eventDate;
        }
    }
}
