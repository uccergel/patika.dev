using System;

namespace DongulerWhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak consoldan girilen sayı dahil sayıya kadar ortlama hesaplayıp konsola yazdıran program
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama" + toplam / sayi);



            //a dan z ye kadar tüm harfleri konsola yazdıralım
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("****** Foreach Döngüsü ********");
            string[] arabalar = { "BMW", "Mercedes", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
