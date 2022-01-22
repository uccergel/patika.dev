using System;

namespace DongulerForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            int sayac = int.Parse(Console.ReadLine()); //Ekrandan string okur.
            for (int i = 1; i < sayac; i++)
            {
                //KOmutlar
                if (i%2 ==1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdıralım
            int tektoplam = 0;
            int cifttoplam = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 1)
                    tektoplam += i;
                else
                    cifttoplam += i;
            }
            Console.WriteLine("tek Toplam: " + tektoplam);
            Console.WriteLine("Çift Toplam: " + cifttoplam);



            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);

            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
