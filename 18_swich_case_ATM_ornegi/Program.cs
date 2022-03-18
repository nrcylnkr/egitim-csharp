using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_swich_case_ATM_ornegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mini Atm uygulaması yapalım. Kullanıcıdan bir değer alalım ve aldığımız değere göre işlemler yapalım (swich-case) kullanıcaz.
            // 1- Bakiye Görüntüleme
            // 2- Para Çek
            // 3- Para Yatır
            // 4- Çıkış Yap
            // 1-2-3-4 dışında bir değer girilmiş ise hata versin.


            int bakiye = 700;

            Console.WriteLine("HOŞGELDİNİZ");

            Console.WriteLine("Lütfen işleminizi seçiniz");
            Console.WriteLine("1- Bakiye Görüntüleme");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3- Para Yatır");
            Console.WriteLine("4- Çıkış Yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz : " +bakiye);
                    Console.ReadLine();
                    break;
                
                case "2":
                    Console.WriteLine("Çekmek İStediğiniz Tutar");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    

                    if (cekilecek_tutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz :" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }

                    break;


                case"3":
                    Console.WriteLine("Yatırmak İstediğiniz Tutar");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni Bakiyeniz" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;

                case"4":
                    Console.WriteLine("Çıkış Yapıldı");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız. Tekrar Deneyiniz");
                    Console.ReadLine();
                    break;

            }






        }
    }
}
