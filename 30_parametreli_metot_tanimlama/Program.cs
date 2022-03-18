using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_parametreli_metot_tanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre alan - Geriye değer döndürmeyen metot yazma

            ToplamaYap(5,7);
            CarpmaYap(5, 11, 7);
            isimsoyisimyazdir("Nur Ceylan", "Özdemir");
            Console.ReadLine();
        }

        static void ToplamaYap(int sayi1 , int sayi2)
        {
            Console.WriteLine("Gönderilen Sayıların Toplamı : " + (sayi1+sayi2));
            //Console.ReadLine();
        }

        static void CarpmaYap(int sayi1, int sayi2, int sayi3 )
        {
            Console.WriteLine("Gönderilen Sayıların Çarpımı : " + (sayi1 * sayi2 * sayi3));
        }

        static void isimsoyisimyazdir (string isim, string soyisim)
        {
            Console.WriteLine("İsim Soyisim : " + isim + " "+ soyisim);
        }
    }
}
