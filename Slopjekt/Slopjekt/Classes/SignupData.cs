using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Slopjekt.Classes
{
    public class SignupData
    {
        public string Username { get; set; }
        public string PromoCode { get; set; }
        public SecureString Password { get; set; }
        public bool hasPromoCode { get; set; }

        public SignupData(string username, SecureString password, string promocode)
        {
            if (username.Length < 5 || username.Trim().Length < 5)
            {
                throw new ArgumentException("SignupData invalid Arguments.", "username");
            }
            if (promocode.Length < 4)
            {
                hasPromoCode = false;              
            }
            Username = username;
            PromoCode = promocode;
            Password = password;
        }

        public SignupData(string username, SecureString password)
        {
            hasPromoCode = false;
            Username = username;
            PromoCode = "";
            Password = password;
        }
    }
}
