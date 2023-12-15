using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodinaJedenact
{
    internal class JmenoException:ArgumentException
    {
        public string Jmeno;
        public DateTime Cas;
        public JmenoException(string param, string message, string jmeno) : base(message, param)
        {

            Jmeno = jmeno;
            Cas= DateTime.Now;
        }

    }
}
