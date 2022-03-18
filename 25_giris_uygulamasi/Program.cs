using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_giris_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcı giriş sayfası uygulaması yapacağız.
            // Kullanıcı adı ve şifresini doğru girerse Tebrikler Başarılı Bir Şekilde Giriş Yaptınız
            // Yanlış girerse hata verelim ve 3 hak tanıyalım kullanıcıya. yanlış girdiği sürece döngü dönmeye devam etsin.

            int hak = 3;
            while (true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz");
                string name = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz");
                string password = Console.ReadLine();   

                if (name == "nurcey" && password == "2110")
                {
                    Console.WriteLine("Tebrikler! Başarılı Bir Şekilde Giriş Yaptınız");
                    break;
                }

                else
                {
                    Console.WriteLine("Hatalı Kullanıcı Adı veya Şifre Girdiniz");
                    if (hak > 0)
                    {
                        hak -= 1;
                    }
                    if (hak == 0)
                    {
                        Console.WriteLine("Hakkınız Dolmuştur");
                        break;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
