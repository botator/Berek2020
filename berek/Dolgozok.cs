using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek
{
    internal class Dolgozok
    {
        public string Nev { get; set; }
        public string Neme { get; set; }
        public string Reszleg { get; set; }
        public int BelepesEv { get; set; }
        public int Ber { get; set; }

        public Dolgozok(string sor)
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            Neme = s[1];
            Reszleg = s[2];
            BelepesEv = Convert.ToInt32(s[3]);
            Ber = Convert.ToInt32(s[4]);
        }
        public override string ToString()
        {
            return "\tNév: "+Nev+"\n\tNem: "+Neme+"\n\tBelépés: "+BelepesEv+"\n\tBér: "+Ber.ToString();
        }
    }
    

}
