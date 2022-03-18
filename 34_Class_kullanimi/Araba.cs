using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Class_kullanimi
{
    public class Araba
    {


        public Araba(int kapisayisi, string arabamodeli, string arabarengi)
        {
            kapi_sayisi = kapisayisi;
            araba_modeli = arabamodeli;
            araba_rengi = arabarengi;
        }



       public int kapi_sayisi;
        public string araba_modeli;
        public string araba_rengi;


       /* public Araba()
        {
            //ctor yazıp tab tab yaparsak kısa yoldan yazmış oluruz.
            Console.WriteLine("Araba Sınıfının yapıcı metodu çalıştı...");
        }
       */
        public void motorcalistir()
        {
            Console.WriteLine("Motor Çalışıyor...");
        }

        public void kapilari_kilitle()
        {
            Console.WriteLine("Kapılar Kilitleniyor...");
        }
    }
}
