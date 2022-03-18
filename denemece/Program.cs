using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemece
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("Oyun Listesi");
                Console.WriteLine(" 1- Saklambaç");
                Console.WriteLine(" 2- Körebe");
                Console.WriteLine(" 3- Puzzle");
                Console.WriteLine(" 4- Boyama");
                Console.WriteLine(" 5- Çıkış");

                string oyun = Console.ReadLine();

                if ( oyun == "1")
                {
                    Console.WriteLine("Saklambaç Oyununa Hoşgeldiniz");
                   // break;
                }

                if (oyun == "2")
                {
                    Console.WriteLine("Körebe Oyununa Hoşgeldiniz");
                   // break;
                }

                if (oyun == "3")
                {
                    Console.WriteLine("Puzzle Oyununa Hoşgeldiniz");
                   // break;
                }

                if (oyun == "4")
                {
                    Console.WriteLine("Boyama Oyununa Hoşgeldiniz");
                   // break;
                }

                if (oyun == "5")
                {
                    Console.WriteLine("Çıkış Yaptınız. Güle Güle");
                    break;
                }

                else
                {
                    Console.WriteLine("Yanlış Bir Tuşa Bastınız");
                    if (hak_sayisi > 0)
                    {
                        hak_sayisi -= 1;
                    }
                    if(hak_sayisi == 0)
                    {
                        Console.WriteLine("Hakkınız Dolmuştur");
                        break;
                    }
                }
            }
            Console.ReadLine();
        } 
    }
}
