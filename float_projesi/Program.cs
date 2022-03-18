using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // float ondalıklı sayılar için yaklaşık 7-8 basamak içerir.
            // ram de 4 byte yer kaplar.

            // sayının sonuna konulan f float türüne çevirdiğimizi gösterir. yoksa double olarak algılar.
            float ondalikli_sayi1 = 17.21f;
            float ondalikli_sayi2 = 94.89f;

            float max_deger = float.MaxValue;
            float min_deger = float.MinValue;
         

            Console.WriteLine(ondalikli_sayi1);
            Console.WriteLine(ondalikli_sayi2);

            Console.WriteLine(max_deger);
            Console.WriteLine(min_deger);

            /*Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);*/

            Console.ReadLine();

            
        }
    }
}
