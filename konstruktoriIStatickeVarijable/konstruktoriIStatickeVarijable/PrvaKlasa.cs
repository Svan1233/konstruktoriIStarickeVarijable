using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktoriIStatickeVarijable
{
    class PrvaKlasa
    {
        static int counter;
        string ime;
        string prezime;
        
        void ToString()
        {
            Console.WriteLine("Redni broj: " + counter + "," + ime + prezime);
            
        }
        
        public PrvaKlasa()
        {
            counter++;
        }

        public static int Counter { get => counter;}
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
