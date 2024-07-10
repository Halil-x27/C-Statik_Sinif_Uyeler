using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Calisan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Halil","Özcan","Yazılım");

            Console.WriteLine("Calisan Sayısı: {0}", Calisan.CalisanSayisi);

           Console.WriteLine( Islemler.Topla(50,22));
            Console.WriteLine(Islemler.Cıkar(20,10)); // static siniflarin değerine böyle erişim sağlanir.
            
        }
    }

    class Calisan 
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string isim;
        private string soyisim;
        private string departman;
        
        static Calisan()
        {
            calisanSayisi = 0;
        }
         public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi ++;
        }

        
    }

    static class Islemler
    {
        public static long Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cıkar(int sayi1 , int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
