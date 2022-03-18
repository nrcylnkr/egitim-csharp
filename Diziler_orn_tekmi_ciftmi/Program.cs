using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_orn_tekmi_ciftmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane int değer alan ve aşağıdaki işlemleri yapan programı kodlayınız.
            // 1- Kaç adet tek ve çift eleman olduğunu
            // 2- Çift değerlerin toplamını, Tek değerlerin toplamını
            // 3- Kontrol yapsın. Çift değerlerin topl. tek değerlerden büyükse Çift değerlerin Toplamı büyüktür yazsın
            //  Tek değerlerin toplamı büyükse, tek değerlerin toplamı büyüktür yazsın.



            int[] sayilar = new int[10];

            int tekadettoplam = 0;      
            int ciftadettoplam = 0;

            int teksaytop = 0;
            int ciftsaytop = 0;

            //int kullanicideger;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write( i + ". index değerini giriniz : ");

                //kullanicideger = int.Parse(Console.ReadLine());
                //sayilar[i] = kullanicideger;  // dizimin içini kullanıcıdan aldığım değerlerle doldurdum.

                sayilar[i] = int.Parse(Console.ReadLine());  // bu kod üsttteki ikisinin daha kısası ve düzgünü çünkü kocam yazdırdı :)
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftadettoplam++;
                    ciftsaytop += sayilar[j];
                }

                else
                {
                    tekadettoplam++;
                    teksaytop += sayilar[j];
                }
            }

            if (ciftsaytop > teksaytop)
            {
                Console.WriteLine("Çift Sayıların Toplamı > Tek Sayıların Toplamı");
            }

            else
            {
                Console.WriteLine("Tek Sayıların Toplamı > Çift Sayıların Toplamı");
            }


            Console.WriteLine("*********************************************************");

            Console.WriteLine("Çift Sayıların Toplamı : " + ciftsaytop);
            Console.WriteLine("Çift Sayıların Adedi : " + ciftadettoplam);

            Console.WriteLine("*********************************************************");

            Console.WriteLine("Tek Sayıların Toplamı : " + teksaytop);
            Console.WriteLine("Tek Sayıların Adedi : " + tekadettoplam);

            Console.ReadLine();

        }
    }
}
