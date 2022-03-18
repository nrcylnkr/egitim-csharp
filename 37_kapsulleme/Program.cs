using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getter setter metotlar,
            // property ile 2 şekilde yapılabilir kapsülleme

            Student student = new Student();

            student.set_Name("Nur Ceylan");
            string gelen_isim = student.get_Name();

            if (gelen_isim=="Nur Ceylan")
            {
                Console.WriteLine("Başarılı");
            }

            else
            {
                Console.WriteLine("Başarısız");
            }
            
           // student.set_age (32);
            
            
            //Console.WriteLine(student.get_Name());

            //Console.WriteLine(student.get_age());   

            Console.ReadLine();

        }
    }
}
