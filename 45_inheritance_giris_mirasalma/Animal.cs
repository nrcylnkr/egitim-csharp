using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_inheritance_giris_mirasalma
{
    public class Animal
    {
        public string animal_name;  
        public string animal_type;
        public string animal_color;
        private int age;



        public void animal_info()   //metot
        {
            Console.WriteLine("Hayvanın Adı: "+ animal_name);
            Console.WriteLine("Hayvanın Cinsiyeti: "+ animal_type);
            Console.WriteLine("Hayvanın Rengi: "+ animal_color);
            Console.WriteLine("Hayvanın Yaşı: "+ age);
        } 
        
        public void set_age(int _age)
        {
            age = _age;
        }

        public int get_animal_age()
        {
            return age;
        }




    }
}
