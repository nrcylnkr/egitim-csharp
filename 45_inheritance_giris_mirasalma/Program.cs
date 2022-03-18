using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_inheritance_giris_mirasalma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //bir class yalnızca bir classı Mira alabilir.

            Cat cat = new Cat();

            
            
            cat.animal_name = "Boncuk";
            cat.animal_type = "Dişi";
            cat.animal_color = "Beyaz";
            cat.set_age(5);
            cat.cat_eyes_color = "Blue";
            cat.animal_info();
            cat.CatMethod();

            Console.ReadLine();
        }
    }
}
