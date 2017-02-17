using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.SessionState;

namespace BookStore.Models.Helper
{
    public enum SessionKey
    {
        CART,
        RETURN_URL
    }

    public class SessionHelper
    {
        public static Type Get<Type>(HttpSessionState _session, SessionKey _key)
        {
            string key = Enum.GetName(typeof(SessionKey), _key);
            object value = _session[key];

            if (value != null && value is Type)
                return (Type)(value);
            else
                return default(Type);
        }

        
        public static void Set(HttpSessionState _session, SessionKey _key, object _value)
        {

            string key = Enum.GetName(typeof(SessionKey), _key);
            _session[key] = _value;
        }


        public static Cart GetCart(HttpSessionState _session)
        {
            string key = Enum.GetName(typeof(SessionKey), SessionKey.CART);
            Cart myCart = (Cart)_session[key];

            if (myCart == null)
            {
                myCart = new Cart();
                Set(_session, SessionKey.CART, myCart);
            }

            return myCart;
        }
    }
}