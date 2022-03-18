using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_For_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int degisken_adi = baslangic_degeri ; koşul ; arttırma azaltma)


            // 1 den 10 a kadar olan sayıları alt alta ekrana yazdıran programı kodlayınız.

            /*
            for (int i = 1; i >= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine(); */


            // 1 den 10 a kaddar olan sayılardan çift olanlarını ekrana yazdır


            for(int a = 0; a <= 10; a = a + 2) // a+=2
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();


        }
    }
}
