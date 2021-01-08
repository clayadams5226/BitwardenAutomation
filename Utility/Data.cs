using System;
using System.Collections.Generic;
using System.Text;

namespace BitwardenAutomation.Utility
{
    public class Data
    {
        public static Data data;
        private static string email;
        private static string password;
        private static string invalidEmail;
        private static string mailSacUser;
        private static string mailSacEmail;
        private static string newAccountEmail;

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

        public static void SetInvalidEmail(string setInvalidEmail)
        {
            invalidEmail = setInvalidEmail;
        }
        public static string GetInvalidEmail()
        {
            return invalidEmail;
        }
        public static void SetMailSacUser(string setMailSacUser)
        {
            mailSacUser = setMailSacUser;
        }
        public static string GetMailSacUser()
        {
            return mailSacUser;
        }
        public static void SetMailSacEmail(string setMailSacEmail)
        {
            mailSacEmail = setMailSacEmail;
        }
        public static string GetMailSacEmail()
        {
            return mailSacEmail;
        }
        public static void SetNewAccountEmail(string setNewAccountEmail)
        {
            newAccountEmail = setNewAccountEmail;
        }
        public static string GetNewAccountEmail()
        {
            return newAccountEmail;
        }
    }
}
