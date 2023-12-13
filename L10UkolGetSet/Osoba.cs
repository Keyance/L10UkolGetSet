using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10UkolGetSet
{
    internal class Osoba
    {
        private string Jmeno { get; set; }
        private string prijmeni;
        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }


        private bool JePlnoleta;
        public bool jePlnoleta
        {
            get
            {
                return JePlnoleta;
            }
            set
            {
                if (vek > 18)
                {
                    JePlnoleta = true;
                }
                else { JePlnoleta = false; }
            }
        }

        private int Vek;
        public int vek
        {
            get
            { return Vek; }
            set
            {
                if (value  < 0)
                {
                    Console.WriteLine("Nebyl zadán reálný věk osoby.");
                }
                else    
                {
                    Vek = value;
                    if (value > 18)
                    {
                        JePlnoleta = true;
                    }
                }
            }
        }
    }
}
