using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_ATM_programi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            // 1- Bakiye görüntüleme
            // 2- Para çekme
            // 3- Para yatırma
            // q ya basarsa çıkış yapılsın.

            int bakiye = 1000;
           

            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1- Bakiye görüntüleme , 2- Para çekme , 3- Para Yatırma, Q- çıkış");
            string secim = Console.ReadLine();

                       
                if (secim == "1")
                {
                    Console.WriteLine("Şuanki Bakiyeniz : " + bakiye);
                    Console.ReadLine();
                }

                else if (secim == "2")
                {
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    
                    if (cekilecek_tutar<=bakiye)
                    {
                    Console.WriteLine("Kalan Tutar :" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                    }
                    else
                    {
                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                    Console.ReadLine();

                    }
                    
                }

                 else if (secim == "3")
                {
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni Bakiyeniz :" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                }

                else if (secim == "q")
                {
                    Console.WriteLine("ATM den çıkış yapılıyor");
                    Console.WriteLine(" İyi Günler...");
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
