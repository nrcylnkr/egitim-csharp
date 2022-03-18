using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_static_yapiici_metot_kullanimi
{
    public class kullanici
    {
        private int id { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private static int salary { get; set; }

        static kullanici()
        {
            salary = 7200;
        }

        public kullanici(int id1, string name1, string surname1)
        {
            id = id1;
            name = name1;
            surname = surname1;
            
        }

        public void get_info()
        {
            Console.WriteLine(" Kullanıcı Bilgileri");
            Console.WriteLine("ID : " +id);
            Console.WriteLine("İsim : " +name);
            Console.WriteLine("Soyisim : " +surname);
            Console.WriteLine("Maaş Bilgisi : " + salary);
        }

        public void Zam()
        {

             double Zam_Miktari = salary*0.15;

            Console.WriteLine("Kullanıcıya Zam Yapılıyor...");
            Console.WriteLine("Şuanki Maaşı : " + (salary+ Zam_Miktari));
        }


    }
}
