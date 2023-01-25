using OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Validate.Concrete
{
    public class Expresso : CoffeeBase
    {
        public override double TutarHesapla(double Adet)
        {
            return Adet * 50;
        }
    }
}
