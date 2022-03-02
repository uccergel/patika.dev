using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namespace
            ArrayList liste = new ArrayList();
            liste.Add("Uğur Cem");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisinde verilere erişim
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Add range
            Console.WriteLine("***** Add Range *****");
            string[] renkler = new {"kırmızı", "sarı", "yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));


            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("***** Sort *****");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            


        }
    }
}
