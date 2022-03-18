using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_endeksi_programi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beden kitle indeksi = kilo/ boy*boy
            // Bedden kitle indeksi 18 e eşit veya düşükse ZAYIF
            // 18 ile 25 arasındaysa NORMAL
            // 25 ten büyükse OBEZ yazdıran program parçasını kodlayınız.

            // "/" veya "*" veya "(" gibi tırnak içine aldıklarımızı ekrana yazdırmak istiyoruz. tırnaktan sonra gelen
            // tırnaktan sonra gelen + ise string değerini ekle demek anlamında.


            Console.WriteLine("Kilonuzu Giriniz");

            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke <= 18)
            {
                Console.WriteLine(kilo + " / " + "(" + boy + " * " + boy + ")" + " = " + bke);
                Console.WriteLine("Zayıfsınız");
                Console.ReadLine();
            }

            else if (bke>18 && bke <= 25)
            {
                Console.WriteLine(kilo + " / " + "(" + boy + " * " + boy + ")" + " = " + bke);
                Console.WriteLine("Normalsiniz");
                Console.ReadLine();
            }

            else if (bke > 25)
            {
                Console.WriteLine(kilo + " / " + "(" + boy + " * " + boy + ")" + " = " + bke);
                Console.WriteLine("Obezsiniz");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                Console.ReadLine();
            }
















        }
    }
}
