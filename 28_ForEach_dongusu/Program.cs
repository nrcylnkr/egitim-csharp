using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ForEach_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach dongusu  -  dizileri daha kestirme yolsan ekrana yazdırmak için kullanılan bir döngüdür

            /* string[] isimler = { "Nur Ceylan", "Enes", "Kerem", "Melis", "Mert Rıza" };


             foreach (string a in isimler)
             {
                 Console.WriteLine(a);
             } */

            double[] os = { 1.1, 1.2, 1.3, 1.4, 1.5 };

            foreach (double d in os)
            {
                Console.WriteLine(d);
            }

            Console.ReadLine();
 
        }
    }
}
