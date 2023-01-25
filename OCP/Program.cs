
using OCP.Ornek2;
using OCP.Ornek2.duzeltilmis;

namespace OCP
{
    internal class Program
    {

        /*
         
         Open Close Principle:

        “sınıflar gelişmeye açık lakin değişmeye kapalı olmalıdır”
         
         */
        static void Main(string[] args)
        {
            //AlanHesaplayici hesaplayici = new();
            //Dikdortgen dikdortgen = new();
            //dikdortgen.KisaKenar = 4;
            //dikdortgen.UzunKenar = 5;
            //Daire daire = new Daire();
            //daire.YariCap = 6;

            DikUcgen dikUcgen = new DikUcgen { KisaKenar = 4, UzunKenar = 5 };
            YeniDaire daire = new YeniDaire { YariCap = 5 };
            YeniDikdortgen dikdortgen = new YeniDikdortgen { UzunKenar = 6, KisaKenar = 9 };


            ISekil dikUcgen2 = new DikUcgen { KisaKenar = 4, UzunKenar = 5 };
            ISekil daire2 = new YeniDaire { YariCap = 5 };
            ISekil dikdortgen2 = new YeniDikdortgen { UzunKenar = 6, KisaKenar = 9 };


            hesapla(dikUcgen);
            hesapla(daire);
            hesapla(dikdortgen);





            Console.WriteLine("Hello, World!");
        }

        static void hesapla(ISekil sekil)
        {
            sekil.AlaHesapla();
        }
    }
}