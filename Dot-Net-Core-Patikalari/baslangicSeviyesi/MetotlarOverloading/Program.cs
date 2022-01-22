using System;

namespace MetotlarOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //metot overloading - Aşırı Yükleme
            int ifade = 999;
            metotlar.EkranaYazdir(Convert.ToString(ifade));
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir("Uğur Cem", "Çergel");
            metotlar.EkranaYazdir("Uğur Cem ", ifade);

            //metot adı + parametre sayısı + parametre
        }

        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1+veri2);
            }
            public void EkranaYazdir(string veri1, int veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
    }
}
