using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversiın : Bilinçsiz Dönüşüm - düşük kapasiteli değişkenin kendinden daha yüksek kapasiteli değişkene atama işlemi

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Uğur Cem";
            char f = 'k';
            object g = e + f + d; //Diğr veri tipleri objectten türeyeb veri tipleridir. Diğerlerinin üzerinde bir veri tipi. Daha yüksek kapasiteli veri tipi
            Console.WriteLine("g: " + g);


            // explicit conversion: Bilinçli Dönüşüm - 

            Console.WriteLine("********* Explicit Conversion ********");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);


            //**** ToStirng Methodu ****
            Console.WriteLine("********* ToStirng Methodu ********");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Convert
            Console.WriteLine("********* System.Convert ********");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + Toplam);

            //Parse
            Console.WriteLine("********* Parse Method ********");
            ParseMethod();
            
        
            
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            //rakam1 = Convert.ToByte

            Console.WriteLine("Rakam1: " + rakam1);
            Console.WriteLine("Double1: " + double1);

        }
    }
}
