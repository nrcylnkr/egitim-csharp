using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_kapsulleme
{
    public class Student
    {
        private string Name;
        private int age;

        public void set_Name(string _name)
        {
            Name = _name;
        }

        public string get_Name()
        {
            return Name;
        }

        public void set_age(int _age)
        {
            age = _age;
        }

        public int get_age()
        {
            return age;
        }
    }
}
