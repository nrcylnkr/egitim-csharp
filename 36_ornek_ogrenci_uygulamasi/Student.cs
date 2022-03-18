using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_ornek_ogrenci_uygulamasi
{
    public class Student
    {
        private int st_no;
        private string name;
        private string surname;
        private int exam1;
        private int exam2;
        private int final;
        private string school_name;


        public Student(int _st_no , string _name , string _surname , int _exam1 , int _exam2 , int _final , string _school_name )
        {
            st_no = _st_no;
            name = _name;
            surname = _surname;
            exam1 = _exam1;
            exam2 = _exam2;
            final = _final;
            school_name = _school_name;
        }



        public void show_student_info()
        {
            Console.WriteLine("Öğrenci Numarası : "+ st_no);
            Console.WriteLine("Öğrenci Adı : " + name);
            Console.WriteLine("Öğrenci Soyadı : " + surname);
            Console.WriteLine("Öğrenci 1. Vize : " + exam1);
            Console.WriteLine("Öğrenci 2. Vize : " + exam2);
            Console.WriteLine("Öğrenci Final : " + final);
            Console.WriteLine("Okul Adı : " + school_name);

        }

        public double st_grade_point_average()
        {
            double average = exam1 * 0.2 + exam2 * 0.2 + final * 0.6;
            return average;
        }


        public void get_school()
        {
            Console.WriteLine("Okul Adı : " + school_name);
        }
    }
}
