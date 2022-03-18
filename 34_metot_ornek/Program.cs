using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_metot_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 tane sayı alalım. Hangisi büyükse; büyük olan sayıyıy ekrana yazdıralım...


            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            kontrol_et(sayi1, sayi2);

            Console.ReadLine();
        }

        static void kontrol_et ( int a , int b)
        {
            if (a > b)
            {
                Console.WriteLine("Birinci Sayi İkinci Sayıdan Büyüktür");
            }

            else if (a == b)
            {
                Console.WriteLine("Birinci Sayi İkinci Sayıya Eşittir");
            }

            else
            {
                Console.WriteLine("Birinci Sayi İkinci Sayıdan Küçüktür");
            }
        }



    }
}
