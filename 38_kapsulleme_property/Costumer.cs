using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_kapsulleme_property
{
    public class Costumer
    {
        // public int kilo;    //değişken

        // prop tab tab

        // public int kilo_2 { get; set; } // get ve set blokları açılmazsa değişkenden bir farkı kalmaz.
        // yukarıdaki gibi get set açılmadan nasıl kullanabilirim... ikisini de aynı amaç için kullanabiliriz.

        public int kilo1 { get; set; }  // property

        public int kilo2; // değişken




        //----------------------------------


      /*  private int kilo;


        public int KILO
        {
            get
            {
                return kilo;
            }
            
            
            set
            {
               // if(value<10)
             // kilo =  0;
              //  else
              //      kilo= value;  // bu da başka bir yolu

                kilo = value;  //value=girilen değer ne ise o 

            }
        }*/

    }
}
