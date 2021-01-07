using System;
using System.Collections.Generic;
using System.Text;

namespace BitwardenAutomation.Utility
{
    public class Data
    {
        public static Data data;
        public static string email;
        public static string password;

        public static Data GetData
        {
            get
            {
                return data;
            }
            private set
            {
                data = value;
            }
        }
        public static void SetEmail(string setEmail)
        {
            email = setEmail; 
        }
        public static string GetEmail()
        {
            return email;
        }
        public static void SetPassword(string setPassword)
        {
            password = setPassword;
        }

        public static string GetPassword()
        {
            return password;
        }
    }
}
