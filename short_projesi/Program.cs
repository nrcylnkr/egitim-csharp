using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short değişkeni -32768 ile 32767 arasında değer depolayabilmektedir.
            short birinci_degisken = -50;

            short ikinci_degisken = 25550;
            short ucuncu_degisken = 32000;

            short max_deger = short.MaxValue;
            short min_deger = short.MinValue;


            Console.WriteLine(max_deger);
            Console.WriteLine(min_deger);

            /*
            Console.WriteLine(birinci_degisken);
            Console.WriteLine(ikinci_degisken);
            Console.WriteLine(ucuncu_degisken);
            */

            Console.ReadLine();
        }
    }
}
