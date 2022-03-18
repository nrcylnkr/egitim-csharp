using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // long veri tipi -9.223.372.036.854.808 ile 9.223.372.036.854.775.807 arasında değer depolayabilmektedir.
            // 8 byte yer kaplar ram bellekte.

            long birinci_degisken = 46120434004;
            long ikinci_degisken = -57076420652;

            long max_deger = long.MaxValue;
            long min_deger = long.MinValue;


            //Console.WriteLine(birinci_degisken);
            //Console.WriteLine(ikinci_degisken); 


            Console.WriteLine(max_deger); 
            Console.WriteLine(min_deger);

            Console.ReadLine();


        }
    }
}
