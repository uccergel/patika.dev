using System;
using System.Collection.Generic;

namespace Kolleksiyonlar_2_Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<T> class
            System.Collection.Generic
            T -> object türündendir.
            */
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            //Liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içinde bulundu");
            }
            
            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi List'e Çevirme
            string[] hayvanlar={"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi Nasıl Temizleriz
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Kullanıcılar kullanıcı1 = new List<Kullanıcılar>();
            kullanıcı1.Isim = "Uğur Cem";
            kullanıcı1.Soyisim = "Çergel";
            kullanıcı1.Yas = 37;

            Kullanıcılar kullanıcı2 = new List<Kullanıcılar>();
            kullanıcı2.Isim = "Esma";
            kullanıcı2.Soyisim = "Çergel";
            kullanıcı2.Yas = 30;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Mehmet Emir",
                Soyisim = "Çergel",
                Yas = 2
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soysisim;
        private int yas;
        public string Isim { get=> isim; set=> isim=value; }
        public string Soyisim { get=> soyisim; set=> soyisim=value; }
        public string Yas { get=> yas; set=> yas=value; }

    }
}
