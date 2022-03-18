using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_metot_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız sayının karesini alalım, eğer karesi 25'ten büyükse
            // karesi 25'ten büyüktür
            // değilse 25'ten küçüktür yazdırsın.

            while (true)
            {
                Console.Write("Sayı Giriniz : ");

                int sayi = int.Parse(Console.ReadLine());

                int sonuc = kare_al(sayi);
                Console.WriteLine(sonuc);


                if (sonuc > 25)
                {
                    Console.WriteLine("Sayının karesi 25'ten büyüktür.");
                    Console.WriteLine();
                }

                else if (sonuc == 25)
                {
                    Console.WriteLine("Sayının karesi 25'e eşittir.");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Sayının karesi 25'ten küçüktür.");
                    Console.WriteLine();
                }


            }
            Console.ReadLine();

        }

        static int kare_al(int a)
        {
           //int sonuc = a * a;
           //return sonuc;
            return a * a;
        }
    }
}
