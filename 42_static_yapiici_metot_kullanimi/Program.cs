using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_static_yapiici_metot_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static yapıcı metot kullanımı

            kullanici K1 = new kullanici(17, "Nur Ceylan ", "Özdemir");
            
           
            K1.get_info();
            K1.Zam();
            
            Console.ReadLine();
        }
    }
}
