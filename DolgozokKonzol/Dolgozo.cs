using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozokKonzol
{
    internal class Dolgozo
    {
        public string nev;
        public string neme;
        public string reszleg;
        public int belepesiev;
        public int ber;

        public Dolgozo(string nev, string neme, string reszleg, int belepesiev, int ber)
        {
            this.nev=nev;
            this.neme=neme;
            this.reszleg=reszleg;
            this.belepesiev=belepesiev;
            this.ber=ber;
        }
    }
}
