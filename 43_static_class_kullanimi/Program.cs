using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_static_class_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // static class kullanımı

            //static classlardan obje oluşturulamaz.
            //static classların içinde static olmayan birşey tanımlanamaz.
            //static classlarda kalıtım yapılamaz...

            //Musteri M1=new Musteri();   // bunu objeyi oluşturamayız. çünkü class sınıfımız static.

            Musteri.id = 7;
            Musteri.print();


        }
    }
}
