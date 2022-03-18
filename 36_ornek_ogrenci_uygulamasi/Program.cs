using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_ornek_ogrenci_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            Student student = new Student(702, "Nur Ceylan" , "Özdemir", 90,85,88, "Özel Üniversite");

            Console.WriteLine("Özel Üniversite Uygulamasına Hoş Geldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");

           // show_transactions();

            while (control)
            {
                Console.WriteLine("");
                show_transactions();
                
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":

                        student.show_student_info();
                        break;

                    case "2":
                      double average =  student.st_grade_point_average();
                        Console.WriteLine(" Öğrencinin Ortalaması : "+ average);
                        break;
                    case "3":
                        student.get_school();
                        break;
                    case "4":
                        control = false;
                        break;
                }

            }

        }

        static void show_transactions()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrencinin Ortalamasını Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");
        }

    }
}
