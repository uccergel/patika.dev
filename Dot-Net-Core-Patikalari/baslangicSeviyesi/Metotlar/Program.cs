using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci ger_dons_tipi metot_adi(parametreListesi/arguman)
            //{
            //komutlar
            //}

            //erisim_belirteci
            //public: heryerden erişilebilir.
            //private: sadece mevcut tanımlanan class içerisinden erişilebilir.

            //geri_donustipi
            //herbir metotun geri dönüş tipi olmayabilir bunun için de "void" yazmamız gerekir.

            int a = 2;
            int b = 3;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.ekranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.ekranaYazdir(Convert.ToString(sonuc2));
            ornek.ekranaYazdir(Convert.ToString(a + b));

        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1 + deger2;
        }
    }
}
