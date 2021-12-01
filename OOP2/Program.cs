// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Cahit Arslan
            GercekMusteri musteri1 = new();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Cahit";
            musteri1.Soyadi = "Demirop";
            musteri1.TcNo = "22222222222";

            //kodlama.io
            TuzelMusteri musteri2 = new();
            musteri2.Id = 2;
            musteri2.VergiNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "12345678901";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



            Console.ReadLine();
        }
    }
}
