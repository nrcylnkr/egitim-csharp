using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_kapsulleme_odev
{
    public class TC_Kimlik
    {
        private string TcNo;

        public string tc_no
        {
            get
            {
                return TcNo.Substring(0, 5)+"******";   //(0,5)-- bu stringin 0. indexinden başla 5 karakter al demek.
            }

            set
            {
                bool control = false;
                if (value.Length == 11)
                {

                    for(int i=0; i<value.Length; i++)
                    {
                        bool is_number = char.IsNumber(value[i]);  //123a456s
                        if (is_number)
                        {
                            // yapmam gereken birşey yok
                        }
                        else
                        {
                            control = true;
                            break;
                        }
                    }

                    if (control)
                    {
                        Console.WriteLine("Tc Kimlik Numaranızda geçersiz karakter bulundu.");
                    }
                    else
                    {
                        TcNo = value;
                    }
                    
                }

                else
                {
                    Console.WriteLine("Girdiğiniz TC Kimlik No 11 karakter değildir...");
                }

            }
        }

    }
}
