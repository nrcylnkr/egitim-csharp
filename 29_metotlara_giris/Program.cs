using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_metotlara_giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametresiz - Geriye değer döndürmeyen Metor Tanımlama... ( en basit metot tanımı)
            // yazdığımız metodu çağırmazsak metot çalışmaz. aşağıdaki gibi çağırıyoruz.
            // yüzlerce selam ver yazılması istenseydi p zaman sadece metodu kopyalamak yeterli

            Selamver();
            Selamver();
            Selamver();
            Selamver();
            Selamver();
            halhatirsor();
        }


        static void Selamver()
        {
            Console.WriteLine("Selamlar :)");
            Console.ReadLine();
        }
        static void halhatirsor()
        {
            Console.WriteLine("naber? nasılsın?");
            Console.ReadLine();
        }
    }
}
