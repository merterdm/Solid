using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CoffieExample
{
    public enum CoffeeType 
    { 
        LAtte=1,
        Expresso=2,
        Capucino =3,
        TurkKahvesi
        
    }

    public class Coffee
    {

        public double GetTotalPrice(double Adet, CoffeeType coffeeType)
        {
            double toplamFiyat=0;

            switch (coffeeType)
            {
                case CoffeeType.LAtte:
                    toplamFiyat += Adet * 60;
                    break;
                case CoffeeType.Expresso:
                    toplamFiyat += Adet * 50;

                    break;
                case CoffeeType.Capucino:
                    toplamFiyat += Adet * 70;
                    break;
                case CoffeeType.TurkKahvesi:
                    toplamFiyat += Adet * 30;
                    break;
                default:
                    break;
            }

            return toplamFiyat;
        }
    }
}
