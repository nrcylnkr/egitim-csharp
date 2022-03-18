using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_static_metot_kullanimi
{
    public class Personel
    {

        public static void Ad_Soyad()
        {
            Console.WriteLine("Nur Ceylan Özdemir");
        }

        public static void Say_top(int no1, int no2)
        {
            Console.WriteLine("İki Sayının Toplamı : " + (no1 + no2));
        }
    }
}
