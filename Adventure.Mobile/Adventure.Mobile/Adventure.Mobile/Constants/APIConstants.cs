using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.Mobile.Constants
{
   public class APIConstants
    {
        public const string BaseApiUrl = "http://192.168.56.1:5000/";
        public const string HolidaysEndpoint = "/api/holidays";
        public const string EventsEndpoint = "api/events/";
        public const string AuthenticateEndpoint = "api/authentication/authenticate";
    }
}
