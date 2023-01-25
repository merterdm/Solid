using SRP.DuzeltilmisOrnek;
using SRP.Entity;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personel ali = new Personel { Ad = "Ali", Soyad = "Yilmaz", Email = "ali@gmail.com", TcNo = "123456789" };
            PersonelCreate personelCreate = new PersonelCreate();
            Logger logger = new Logger(@"personel2.txt", "Test");
            personelCreate.PersonelEkle(ali);

            Console.WriteLine("Hello, World!");
        }
    }
}