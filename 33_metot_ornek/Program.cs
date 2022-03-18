using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_metot_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayı tek mi çift mi olduğunu bulan metot yazalım.

            while (true)
            {
                Console.WriteLine("Bir Sayi Giriniz : ");

                int girilensayi = Convert.ToInt32(Console.ReadLine());

                tekmiciftmi(girilensayi);

               /* if (ciftmi(girilensayi))
                {
                    Console.WriteLine("Sayı Çifttir...");
                }

                else
                {
                    Console.WriteLine("Sayı Tektir...");
                } */

                
            }
            
            Console.ReadLine();
        }

        static void tekmiciftmi(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir...");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Sayı Tektir...");
                Console.WriteLine();
            }
        }

        /* static bool ciftmi (int sayi)
         {
             if (sayi % 2 == 0)
             {
                 return true;
             }

             else
             {
                 return false;
             } 
         }*/

    }
}
