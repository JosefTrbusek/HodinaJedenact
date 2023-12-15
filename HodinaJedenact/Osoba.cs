using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HodinaJedenact
{
    internal class Osoba
    {
        private string _jmeno;
        private string _prijmeni;
        private int _vek;

        public string Jmeno { 
            get 
            { 
                return _jmeno;
            }
            set
            {
                _jmeno = value;
            } 
        }

        public string Prijmeni 
        {
            get
            {
                return _prijmeni;
            }
            set
            {
                _prijmeni = value;
            }
        }

        public int Vek 
        {
            get
            {
                return _vek;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Vek","Vek nemuze byt zaporny");
                }
                if(value>150)
                {
                    throw new ArgumentOutOfRangeException("Vek","Moc velky vek");
                }
                _vek = value;
            }
        }

        public bool JePlnoleta
        {
            get
            {
                return _vek >= 18;
            }
        }

        public override string ToString()
        {
            return $"{_jmeno} {_prijmeni} Vek: {_vek} {(JePlnoleta ? "Je" : "Neni")} plnoleta";
        }
        public Osoba(string jmeno, string prijmeni, int vek)
        {
            ArgumentNullException.ThrowIfNull(jmeno,nameof(jmeno));
            if(String.IsNullOrEmpty(jmeno))
            {
                throw new ArgumentException("jmeno nemuze byt prazdne", nameof(jmeno));
            }
            if(String.IsNullOrWhiteSpace(jmeno))
            {
                //throw new ArgumentException("jmeno nemuze obsahovat bile znaky", nameof(jmeno));
                throw new JmenoException(nameof(jmeno),"jmeno nemuze mit bile znaky", jmeno);
            }
            Jmeno= jmeno;
            Prijmeni= prijmeni;
            Vek= vek;

        }
    }
}
