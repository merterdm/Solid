using OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Validate.Concrete
{
    public class Latte : CoffeeBase
    {
        public override double TutarHesapla(double Adet)
        {

            // fiyat bilgilerini db'den cektiniz
            return Adet * 60;
        }
    }
}
