using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstQuestion();
            //SecondQuestion();

            /*
             * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
             * Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
             * Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
             */
            Console.WriteLine("Kaç adet kelime girmek istersiniz: ");
            int n = Console.ReadLine();


        }

        private static void SecondQuestion()
        {
            /*
             * Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             * Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
             */
            Console.WriteLine("İki adet pozitif sayı giriniz!!!");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] nlist = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
                nlist[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in nlist)
            {
                if (i == m || i % m == 0)
                {
                    Console.WriteLine("Kurala uyan sayı: " + i);
                }
            }
        }

        private static void FirstQuestion()
        {
            /*
             * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
             */
            Console.WriteLine("Çift sayı bulmak için girmek istediğiniz sayı miktarı: ");
            int n = int.Parse(Console.ReadLine());
            int[] nlist = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
                nlist[i] = int.Parse(Console.ReadLine());
            }

            foreach (var i in nlist)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Girdiğiniz çift sayı: " + i);
                }
            }
        }
    }
}
