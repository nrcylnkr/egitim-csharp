using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_erisim_belirleyiciler
{
    public class Musteri   //class
    {
        public string name;

        public string surname;

        public int salary;

        public string sex;

        private int age;


        // Eğer bir değişken veya bir metot private tanımlı ise Dış dünyaya kapalıdır demektir.
        // sadece tanımladığımız class içinde erişebiliriz.


        public Musteri()
        {
            Console.WriteLine("Müsteri Sınıfının Yağıcı Metodu Çalıştı");
        }



        public void show_costumer_info()  //metot
        {
            Console.WriteLine("İsim : "+ name);
            Console.WriteLine("Soyisim : "+ surname);
            Console.WriteLine("Maaş Değeri : "+ salary);
            Console.WriteLine("Cinsiyet : "+ sex);
            Console.WriteLine("Yaş : " +age);
        }

        private void name_surname(string costumer_name, string costumer_surname)  //metot
        {
            Console.WriteLine("Müşterinin Adı ve Soyadı : "+ costumer_name +" "+ costumer_surname);
        }
        

    }
}
