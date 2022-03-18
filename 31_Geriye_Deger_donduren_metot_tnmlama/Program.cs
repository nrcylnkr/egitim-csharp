using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Geriye_Deger_donduren_metot_tnmlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre alan- Geriye değer döndüren metot tanımlama
            //Return anahtar kelimesi - geriye döndür anlamına gelir
            //metot sonu.

            /*int donendeger = toplamayap(6, 7);
             Console.WriteLine(donendeger);
             //Console.ReadLine();

             if(donendeger >10)
             {
                 Console.WriteLine("Değer 10'dan büyüktür");
                 Console.ReadLine();
             }
             else
             {
                 Console.WriteLine("Değer 10'dan küçüktür");
                 Console.ReadLine();
             }*/


            string GelenisimsoyisimDegeri = IsımSoyisimDondur("Nur Ceylan", "Özdemir");
            Console.WriteLine(GelenisimsoyisimDegeri);
            Console.ReadLine();
        }

        /*static int toplamayap (int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }*/

        static string IsımSoyisimDondur(string Isim, string Soyisim)
        {
            return Isim + " " + Soyisim;
            //1. değerleri döndürmesi
            //2. return anahtar kelimesi metodu bitiren anahtar kelimedir.
        }





    }
}
