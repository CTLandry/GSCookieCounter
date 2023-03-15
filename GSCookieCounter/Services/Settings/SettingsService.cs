using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSCookieCounter.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        private const string AccessToken = "access_token";
        private const string IdToken = "id_token";
        private const string IdUseMocks = "use_mocks";
        private const string IdUseFakeLocation = "use_fake_location";
        private const string IdLatitude = "latitude";
        private const string IdLongitude = "longitude";
        private const string IdAllowGpsLocation = "allow_gps_location";
        private readonly string AccessTokenDefault = string.Empty;
        private readonly string IdTokenDefault = string.Empty;
        private readonly bool UseMocksDefault = true;
        private readonly bool UseFakeLocationDefault = false;
        private readonly bool AllowGpsLocationDefault = false;
        private readonly double FakeLatitudeDefault = 47.604610d;
        private readonly double FakeLongitudeDefault = -122.315752d;
       

        public string AuthAccessToken
        {
            get => Preferences.Get(AccessToken, AccessTokenDefault);
            set => Preferences.Set(AccessToken, value);
        }

        public string AuthIdToken
        {
            get => Preferences.Get(IdToken, IdTokenDefault);
            set => Preferences.Set(IdToken, value);
        }

        public bool UseMocks
        {
            get => Preferences.Get(IdUseMocks, UseMocksDefault);
            set => Preferences.Set(IdUseMocks, value);
        }

        public bool UseFakeLocation
        {
            get => Preferences.Get(IdUseFakeLocation, UseFakeLocationDefault);
            set => Preferences.Set(IdUseFakeLocation, value);
        }

        public string Latitude
        {
            get => Preferences.Get(IdLatitude, FakeLatitudeDefault.ToString());
            set => Preferences.Set(IdLatitude, value);
        }

        public string Longitude
        {
            get => Preferences.Get(IdLongitude, FakeLongitudeDefault.ToString());
            set => Preferences.Set(IdLongitude, value);
        }

        public bool AllowGpsLocation
        {
            get => Preferences.Get(IdAllowGpsLocation, AllowGpsLocationDefault);
            set => Preferences.Set(IdAllowGpsLocation, value);
        }
    }
}
