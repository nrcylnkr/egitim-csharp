using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Class_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kapisayisi = 4;
            string arabamodeli = "BMW";
            string arabarengi = "Kırmızı";


            Araba araba1 = new Araba(4,"BMW","Kırmızı");
            Console.WriteLine("Arabanın Rengi : "+araba1.araba_rengi);
            Console.WriteLine("Araba Modeli : "+araba1.araba_modeli);
            Console.WriteLine("Kapı Sayısı : "+araba1.kapi_sayisi);
           
            
            
            
            
            
            /*araba1.kapı_sayisi = 4;
            araba1.araba_rengi = "kırmızı";
            araba1.araba_modeli = "BMW";*/

            araba1.kapilari_kilitle();
            araba1.motorcalistir();

           /* Console.WriteLine("Arabanın Kapı Sayısı : " + araba1.kapi_sayisi);
            Console.WriteLine("Arabanın Rengi : " + araba1.araba_rengi);
            Console.WriteLine("Arabanın Modeli : " + araba1.araba_modeli); */

            Console.ReadLine();



            // Yapıcı metot(constructor method): classlardan obje oluşturdupum sırada oluşan, geriye dönüş tipi olmayan metottur.
             
        }
    }
}
