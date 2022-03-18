using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_kapsulleme_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //property nedir( özellik)

          /*  Costumer costumer1 = new Costumer();

            costumer1.KILO = 43;   // Değer atama yapıyorum o zaman set bloklarım çalışır
                                   // Eğer değer ataması yapmasaydım o zaman get bloklarım çalışırdı.
                                   // yanında mavi kutu varsa değişkendir. İngiliz anahtarı varsa property dir
            Console.WriteLine(costumer1.KILO); */


            //---------------------------------------------------

            Costumer c1 = new Costumer();

            c1.kilo1 = 43;
            c1.kilo2 = 141;
            Console.WriteLine("Property Olan Kilo " + c1.kilo1);
            Console.WriteLine("Değişken Olan Kilo " + c1.kilo2);




            Console.ReadLine();
        }
    }
}
