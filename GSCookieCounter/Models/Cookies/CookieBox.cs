using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSCookieCounter.Models.Cookies
{
    public class CookieBox
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; }
        public int TypeId { get; }
        public int EventId { get; }
        [SQLite.Ignore]
        public string CookieBoxImage { get; }

        public CookieBox(Cookie.CookieType type, int eventId)
        {
            TypeId = (int)type;
            EventId = eventId;
        }
    }
}
