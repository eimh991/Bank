using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public  class Client
    {
        private static int id { get; set; }
        private static string name { get; set; }
        private static string surname { get; set; }
        private static float balance { get; set; }
        private static int registarionId { get; set; }

        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public static float Balance
        {
            get { return balance; }
            set { balance= value; }
        }
        public static int RegistarionId
        {
            get { return registarionId; }
            set { registarionId = value; }
        }

    }
}
