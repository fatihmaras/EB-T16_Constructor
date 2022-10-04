using EB_T16_Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickYapiciMethodKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kullanici K1 = new Kullanici(1, "Fatih", "Maraş", 2500);

            K1.BilgileriGoster();
            K1.ZamYap(700);

            Console.ReadLine();



        }
    }

}
