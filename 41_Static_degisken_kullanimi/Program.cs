using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Static_degisken_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // static değişken kullanınımı

            calisan C1= new calisan();

            C1.id = 1;
            C1.name = "Nur Ceylan";
            C1.surname = "Özdemir";

            calisan.salary = 100;

            Console.WriteLine("Çalışam ID: " + C1.id);
            Console.WriteLine("Çalışan İsim Soyisim: " + C1.name + " " + C1.surname);
            Console.WriteLine("Çalışan Maaşı: " + calisan.salary);

            Console.ReadLine();

        }
    }
}
