using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_tur_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetType : değişkenin tipini döndürür.
            //(byte) : tipini değiştirmek için parantez içinde yazmamız gerekiyo değiştirmek istediğimiz değişkeni.

            /* int a = 7;

             byte b = (byte)a;
            
             Console.WriteLine(b.GetType());
             Console.WriteLine(b);
             Console.ReadLine(); */


            // STRING VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞTÜRDÜK.
            // int.Parse de, değişkenin tipini  int olarak değiştirir.
            // Convert.ToInt32 de, değişkenin tipini int e çevirir.

            /* string sayi1 = "1";
            string sayi2 = "2";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine(a+b);
            Console.ReadLine(); */

            /*int sayi1 = 5;
            int sayi2 = 10;

            string a = sayi1.ToString();
            string b = sayi2.ToString();

            Console.WriteLine(a + b);
            Console.ReadLine();*/

            // DOUBLE VERİ TİPİNDEN İNT E DÖNÜŞTÜRME.

            /* double sayi = 3.14;

            int a = Convert.ToInt32(sayi);

            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
            Console.ReadLine(); */


            // kullanıcıdan alınan değerler STRING veri tipinde olur.
            /*
            Console.WriteLine("Lütfen yaşınızı giriniz");

            string kullanici_yas = Console.ReadLine();

            Console.WriteLine("Lütfen eşinizin yaşınızı giriniz");

            string esinin_yasi = Console.ReadLine();


            int a = Convert.ToInt32(kullanici_yas);
            int b = Convert.ToInt32(esinin_yasi);

            Console.WriteLine("Yaşlarınızın toplamı : ");
            //string yaslar_toplami = kullanici_yas + esinin_yasi;
            int x = a + b;

            Console.WriteLine(x);

            //int kullanici_yas_int = int.Parse(kullanici_yas);
            //int kullanici_yas_int2 = Convert.ToInt32(kullanici_yas);


            //Console.WriteLine(kullanici_yas_int);
            //Console.WriteLine(kullanici_yas_int2);
            Console.ReadLine(); */


            //kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran program yazdık.

            // ToString();
            // Convert.ToInt();
            // int.Parse();
            // double.Parse();
            //(int)

             


        }
    }
}
