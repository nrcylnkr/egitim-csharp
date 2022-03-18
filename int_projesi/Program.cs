using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int veri tipi -2.147.483.648 ile 2.147.483.467 arasında değer depolayabilmektedir.
            // 4 byte yer kaplar ram bellekte.

            //8 bit: 1 byte
            //1024 byte : 1KB
            //1024 kb: 1mb
            //1024 mb: 1gb
            //1024 gb: 1tb
            //1024 tb: 1pb (petabyte)


            int birinci_degisken = 170021;
            int ikinci_degisken = -170021;

            int max_deger = int.MaxValue;
            int min_deger = int.MinValue;

            /*
            Console.WriteLine(birinci_degisken);
            Console.WriteLine(ikinci_degisken);
            */
            Console.WriteLine(max_deger);
            Console.WriteLine(min_deger);
            Console.ReadLine();


        }
    }
}
