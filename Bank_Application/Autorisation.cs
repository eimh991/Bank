using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class Autorisation
    {
        private static string login { get; set; }
        private static string password { get; set; }

        public static string Login
        {
            get { return login; }
            set { login = value; }
        }
        public static string Pasword
        {
            get { return password; }
            set { password = value; }
        }
    }
}
