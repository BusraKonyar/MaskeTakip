using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            SelamVer(isim:"Engin");
            SelamVer(isim:"büşra");
            SelamVer(isim:"ahmet");
            SelamVer();

            int sonuc = Topla(3,5);

            //diziler/arrays
            string ogrenci1 = "Büşra";
            string ogrenci2 = "Büşra2";
            string ogrenci3 = "Büşra3";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Büşra";
            ogrenciler[1] = "Büşra2";
            ogrenciler[2] = "Büşra3";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1= new string[]{"Ankara","İstanbul","Malatya"};   
            string[] sehirler2= new string[]{"Ankara2","İstanbul2","Malatya2"};

            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler2[0]);

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1= new Person();
            person1.FirstName="Büşra";
            person1.LastName = "Konyar";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 123;





            Person person2= new Person();
            person2.FirstName="büşraaa2";

            List<string>yenisehirler1= new List<string> { "Ankara3", "İstanbul3", "Malatya3" };
            yenisehirler1.Add(item: "Ardahan");

            foreach (var item in yenisehirler1)
            {
                Console.WriteLine(item);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }
        static void SelamVer(string isim="isimsiz") //isimsiz default parametre
        {
            Console.WriteLine("merhaba"+isim);
        }
        static int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1+sayi2;
            Console.WriteLine("toplam:"+sonuc.ToString());
            return sonuc;
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
        
    }
}
