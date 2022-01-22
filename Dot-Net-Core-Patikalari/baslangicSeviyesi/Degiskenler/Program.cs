using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;
            string Degisken = null;
            //int 3degisken = null; bu şekilde değişlen atanamaz
            //string class = "";
            // aynı simli iki değişken tanımlanamaz
            //string degisken + deger; 
            string degisken_veri = null;
            string degisken2 = " ";
            byte b = 5; //değeri 5 olanb byte tanımlandı. 0 ile 255 arasında değer alır.
            sbyte c = 5; // sbyte ve byte 1 byte yer kaplar. -128 ile 127 araında değer alır.
            short s = 5; //belekte 2 byte yer kaplar. -32768 ile 32768 arasında tam sayı değerler alır.
            ushort us = 5; //bellekte 2 byte yer kaplar. 0 ile 65365 arasında değer alır.
            Int16 i16 = 2; //bellekte 2 byte yer kaplar.
            int i = 2; // bellekte 4 byte yer kaplar. -2147483648 ile 2147483648 arasında değer alır.
            Int32 i32 = 2; // bellekte 4 byte yer kaplar. -2147483648 ile 2147483648 arasında değer alır.
            uint ui = 2; //bellekte 4 byte yer kaplar.
            long l = 4; //bellekte 8 byte yer kaplar.
            ulong ul = 4; //bellekte 8 byte yer kaplar
            float f = 5; // bellekte 4 byte yer kaplar reel sayılar
            double d = 5; //bellekte 8 byte yer kaplar reel sayılar
            decimal de = 5; //bellekte 16 byte yer kaplar reel sayılar
            char ch = '2'; //bellekte 2 byte yer kaplar
            string str = "Zikriye"; //bellekte sınırsız yer kaplar
            bool b1 = true;
            bool b2 = false;
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Uğur Cem Çergel";
            string ad = "Uğur Cem";
            string soyad = "Çergel";
            string tamisim = ad + " " + soyad;

            // int ifadeler
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean
            bool bo1 = 10 < 2;

            //değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktısı 40

            int int22 = int20 + int.Parse(str20); // Çıktısı 40
            Console.WriteLine(int22);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
