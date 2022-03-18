using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_diziler_giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] sayilar = new int[4];
             sayilar[0] = 1;
             sayilar[1] = 2;
             sayilar[2] = 3;
             sayilar[3] = 4;

             for(int i = 0; i < sayilar.Length; i++)  // length boyutu demek. yani biz burda boyuutundan küçük olduğu kadar dönndür demek istedik.
             {
                 Console.WriteLine(sayilar[i]);  
             }
             Console.ReadLine(); */


            //-----------------------------------------------


            /*
            //string // double // char

            string[] isimler = { "enes", "ve", "nur", "ceylan", "özdemir" };
            int[] tarih = { 21, 10, 2020 };
            double[] boylari = { 1.55, 1.88 };
            char[] ask = { 'A', 'Ş', 'K', 'I' };

            //Console.WriteLine(isimler[0]);

            for (int i = 0; i < isimler.Length; i++)
             {
                 Console.Write(isimler[i]+" ");
             }
             Console.WriteLine();

            for (int i = 0; i < ask.Length ; i++)
            {
                Console.Write(ask[i]);
            }
            Console.WriteLine();

            for (int i = 0; i< tarih.Length; i++)
             {
                 Console.Write(tarih[i]+".");
             }
            Console.WriteLine();

            for (int i = 0; i < boylari.Length; i++)
            {
                Console.Write(boylari[i]+" ");
            }
            Console.WriteLine();

            Console.ReadLine();
            */


            //--------------------------------------------------

            //Dizinin elemanlarını kullanıcıdan alma ve ekrana yazdırma.

            int[] sayilar = new int[4];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayılar Dizisinin" + " " + (i + 1) + ". index değerini giriniz :");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine(" ");
            Console.WriteLine("*****************************************");

            for(int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine((i+1) + ". değer : " + sayilar[i]);

            }
            Console.ReadLine();
        }
    }
}
