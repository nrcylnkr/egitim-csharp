using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayı, dizinin içinde var mı ? Kontrol eden varsa kaç tane olduğunu söyleyen, yoksa da yoktur diye uyarın
            // programı kodlayınız.

            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20,35, 65, 5, 20, 35, 65, 80 };
            int adet = 0;
            int sayi;
            string a="";       // string değeri tanımladık ki atadığımız sayı ile çıkış yapabilelim.
            while (a!="-1")    // burada -1 tanımladığımız sayıyı çıkış yapmak için yaptık
            {
                Console.Write("Lütfen bir sayı giriniz : ");

                sayi = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayi == sayilar[i])
                    {
                        adet++;
                    }
                }
                if (adet == 0)
                {
                    Console.WriteLine("Girdiğiniz Değer Dizide Bulunamadı...");
                }

                else
                {
                    Console.WriteLine("Girdiğiniz Değer Dizide Bulundu");
                    Console.WriteLine("Adet : " + adet);
                }
                adet= 0;
                a=Console.ReadLine();
            }
            
        }
    }
}
