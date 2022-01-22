using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 86, 4, 72, 3, 11, 17 };
            Console.WriteLine("***** Sırasız Liste*****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sıralı Liste *****");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear - İndexte verdiğiniz elemandan başlayarak verdiğiniz eleman sayısı kadar değeri sıfırlar 
            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi, 2, 2); //sayiDizisinin 2. elemanından itibaren 2 tanesini sıfırlar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse - terse çevirir
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf - hangi sırada olduğu bilgisini verir.
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            //Resize - yeniden boyutlandırır, bıyutunu değiştirir.
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
