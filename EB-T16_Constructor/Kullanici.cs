using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_T16_Constructor
{
    public class Kullanici
    {
        private int KullaniciID { get; set; }
        private string isim { get; set; }
        private string Soyisim { get; set; }

        private static int Maas { get; set; }


        static Kullanici()
        {
            Maas = 2500;

        }
        public Kullanici(int xKullaniciID, string xisim, string xsoyisim, int xmaas)
        {
            KullaniciID = xKullaniciID;
            isim = xisim;
            Soyisim = xsoyisim;

        }
        public void BilgileriGoster()
        {
            Console.WriteLine("Kullanıcı Bilgileri");
            Console.WriteLine("id : " + KullaniciID);
            Console.WriteLine("isim :  " + isim);
            Console.WriteLine("soyisim : " + Soyisim);
            Console.WriteLine("Maaş : " + Maas);
        }

        public void ZamYap(int ZamMiktari)
        {
            Console.WriteLine("Kullanıcıya Zam Yapılıyor...");
            Console.WriteLine("Şuanki Maaşı : " + (Maas + ZamMiktari));
        }
    }
}
