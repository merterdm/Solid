﻿using DIP.Loglama.Abstract;
using DIP.Loglama.Concrete;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //KofteciRamiz ramiz = new KofteciRamiz();
            //ramiz.Pisir();
            #region Ornek 1
            //IPisir Kofte = new YeniKofte();
            //IPisir tavuk = new YeniTavuk();
            //IPisir patates = new Patates();

            //List<IPisir> urunlerim = new List<IPisir>();
            //urunlerim.Add(patates);
            //urunlerim.Add(tavuk);
            //urunlerim.Add(Kofte);

            //KofteciYusuf kofteciYusuf = new KofteciYusuf(urunlerim);

            //kofteciYusuf.Pisir(); 
            #endregion


            #region Ornek 2

            ILogger filelogger = new FileLogger();


            ILogger DbLogger = new DbLogger();
            Loglayici loglayici = new Loglayici();

            loglayici.Logla(filelogger, "Deneme");

            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}