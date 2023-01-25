using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Ornek
{
    public class KofteciRamiz
    {
        private Kofte kofte = new Kofte();
        private Tavuk tavuk = new Tavuk();


        public void Pisir()
        {
            kofte.KoftePisir();
            tavuk.TavukPisir(); 
        }
    }
}
