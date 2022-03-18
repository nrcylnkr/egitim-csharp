using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_For_dongusu_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı alacağız ve 0'dan başlayıp aldığımız sayıya kadar olan sayıları toplayacağız
            // ve girdiği sayıyı böleceğiz. Eğer ortalama 50 den büyükse, Ort. 50 den büyüktür
            // küçükse ort. 50 den küçüktür yazdıracağız.

            Console.WriteLine("Lütfen Bir Sayı Giriniz: ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i <= sayi; i++)
            {
                toplam+= i; //toplam=toplam+i;
            }

            double ortalama = toplam / sayi;
            if(ortalama > 50)
            {
                Console.WriteLine("Ortalamanız 50'den büyüktür.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Ortalamanız 50'den küçüktür.");
                Console.ReadLine();
            }

        }
    }
}
