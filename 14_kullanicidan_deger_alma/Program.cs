using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_kullanicidan_deger_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ReadLine kullanıcıdan değerler almamızı sağlayan bir metottur

            Console.WriteLine("Lütfen adınızı giriniz");

            string isim = Console.ReadLine();

            Console.WriteLine("Soyismizini giriniz");

            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının ismi : " + isim);
            Console.WriteLine("Kullanıcının soyismi : " + soyisim);
            Console.ReadLine();
        }
    }
}
