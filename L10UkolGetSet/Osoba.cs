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
        private string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }

        bool JePlnoleta
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

        private int vek;
        int Vek
        {
            get
            { return vek; }
            set
            {
                if (value  < 0)
                {
                    Console.WriteLine("Nebyl zadán reálný věk osoby.");
                }
                else    
                {
                    vek = value;
                    if (value > 18)
                    {
                        JePlnoleta = true;
                    }
                }
            }
        }
    }
}
