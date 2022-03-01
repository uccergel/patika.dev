using System;

namespace String-Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Merhaba";
            string degisken2 = "Csharp";

            //Length
            Console.WriteLine(degisken.Length);
            //ToLower ToUpper
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());
            //Concat
            Console.WriteLine(degisken.Concat(" Merhaba")); //degisken sonuna Concat içindeki metni ekler
            //Compare CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken2,true)); //Büyük Küçük harf kontrol etmez.
            Console.WriteLine(String.Compare(degisken,degisken2,false)); //Büyük Küçük harf kontrol eder.
            //Contains
            Console.WriteLine(degisken.Contains(degisken2)); //degisken içinde degisken2 var mı?
            Console.WriteLine(degisken.EndsWith("Merhaba")); //degisken Merhaba ile bitiyor mu?
            Console.WriteLine(degisken.StartsWith("Dersimiz")) //degisken Dersimiz ile başlıyor mu?
            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS")); //degisken içinde CS nereden başlıyor
            Console.WriteLine(degisken.IndexOf("Ugur")); //İçermezse -1 verir.
            Console.WriteLine(degisken.LastIndexOf("i")) //son i nereden başlar
            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            //PadLeft PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30)); //degisken2nin soluna 30 karaktere tamamlayacak kadar boşluk ekler
            Console.WriteLine(degisken + degisken2.PadLeft(30,"*")); //degisken2nin soluna 30 karaktere tamamlayacak kadar * ekler
            Console.WriteLine(degisken.PadRight(50) + degisken2); //degisken1in sağına 50 karaktere tamamlayacak kadar boşluk ekler
            Console.WriteLine(degisken.PadRight(50,"*") + degisken2); //degisken1in sağına 50 karaktere tamamlayacak kadar * ekler



        }
    }
}