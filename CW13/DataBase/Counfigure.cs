using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW13.DataBase
{
    public static class Counfiguer
    {
        public static string Connectionstring { get; set; }
        static Counfiguer()
        {
            Connectionstring = @"Data Source=LEILI\LEILA;Initial Catalog=CW13;Integrated Security=true; TrustServerCertificate=True";
        }
    }
}
