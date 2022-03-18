using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // toplama operatörü : +
            // çıkarma operatörü : -

            /*
            int sayi1 = 17;
            int sayi2 = 21;
            int sayi3 = 6;
            int sayi4 = 13;

         
            int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            Console.WriteLine(sonuc);
            Console.ReadLine();
            */

            //-----------------------

            //çarpma operatörü : *
            //bölme operatörü : /

            /*
             int sayi1 = 7;
             int sayi2 = 11;

             int sonuc = sayi1 * sayi2;

             Console.WriteLine(sonuc);
             Console.ReadLine();
            */


            /*
            int sayi3 = 21;
            int sayi4 = 3;

            int sonuc1 = sayi3 / sayi4;

            Console.WriteLine(sonuc1);
            Console.ReadLine();
            */

            //-----------------------

            // mod alma operatörü : %
            // bir sayıyı bir sayıyı böldüğümüzde kalan değerini verir.

            /*
            int sayi5 = 16;
            int sayi6 = 5;
            
            Console.WriteLine(sayi5 % sayi6);
            Console.ReadLine();
            */

            //-----------------------

            //Arttırma operatörü : ++
            //Azaltma operatörü : --

            /*
            int sayi7 = 16;

            //sayi7++;
            sayi7--;

            Console.WriteLine(sayi7);
            Console.ReadLine();
            */

            //-----------------------

            // Atama operatörü : =

            //int yas = 32;

            // 32 yi al yas değişkeninin içine ata demek.

            //-----------------------

            //Eşittir operatörü : ==

            /* int sayi8 = 4;
             int sayi9 = 4;

             bool kontrol_et = sayi8 == sayi9;

             Console.WriteLine(kontrol_et);
             Console.ReadLine();*/

            /*int sayi8 = 4;
            int sayi9 = 5;

            bool kontrol_et = sayi8 == sayi9;

            Console.WriteLine(kontrol_et);
            Console.ReadLine();*/

            //Eşit değildir operatörü : !=

            /* int sayi10 = 7;
             int sayi11 = 8;

             bool kntrl = sayi10 != sayi11;

             Console.WriteLine(kntrl);
             Console.ReadLine();*/

            //-----------------------

            //Büyüktür operatörü : >
            // Büyük eşittir operatörü : >=
            // küçüktür operatörü : <
            // küçük eşittir operatörü : <=
            // aşağıdaki işlemlerin simgelerini değişirsen olur birdaha yazmama gerek yok :)

            /*
            int yas = 18;

            bool kontrol = yas > 18;
            bool kontrl = yas >= 18;

            Console.WriteLine(kontrol);
            Console.WriteLine(kontrl);

            int yas1 = 19;

            bool kontrol1 = yas1 > 18;
                       
            Console.WriteLine(kontrol1);
            Console.ReadLine();
            */

            //-----------------------

            // mantıksal operatörler
            // ve (and) operatörü : && , shift+6 tuşu. ve de hepsi true ise true olur eğer birtane bile false çıkarsa o zaman sonuç false olur.
            /*
            int sayi = 5;
            int sayi1 = 5;
            int sayi2 = 10;

            bool kontrol = sayi == sayi1 && sayi < sayi2;

            Console.WriteLine(kontrol);
            Console.ReadLine(); */

            //-----------------------

            // veya (or) operatörü : || altgr+z tuşunun sol yanındaki tuş. bir tane true olsa geri kalan hepsi false çıksa bile sonuç true çıkar.
            //hepsi false olursa false çıkar.

            /*int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrol = sayi1 == sayi2 || sayi2 > sayi3;

            Console.WriteLine(kontrol);
            Console.ReadLine(); */

            //-----------------------

            // değil operatörü : !
            // kısacası var olan bir şeyin zıttına çevirir.

            /*bool a = true;

            Console.WriteLine(!a);
            Console.ReadLine();*/

            //-----------------------


            // EK OPERATÖRLER
            // += , -= , *= , /=

            /*
            int a = 5;

            //a = a + 4;
            //a += 4;

            //a = a - 3;
            //a -= 3;

            //a = a * 3;
            //a *= 3;

            //a = a / 5;
            a /= 5;

            Console.WriteLine("a'nin degeri :" +a);

            Console.ReadLine(); */

        }
    }
}
