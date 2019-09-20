using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.Mobile.Constants
{
   public class APIConstants
    {
        public const string BaseApiUrl = "http://192.168.56.1:5000/";
        public const string Holiday = "api/catalog/pies/";
        public const string PiesOfTheWeekEndpoint = "api/catalog/piesoftheweek/";
        public const string ShoppingCartEndpoint = "api/shoppingcart";
        public const string AddShoppingCartItemEndpoint = "api/shoppingcart/";
        public const string AddContactInfoEndpoint = "api/contact";
        public const string PlaceOrderEndpoint = "api/order";
        public const string RegisterEndpoint = "api/authentication/register";
        public const string AuthenticateEndpoint = "api/authentication/authenticate";
    }
}
