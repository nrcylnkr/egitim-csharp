using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_break_continue_anahtar_programi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Break anahtar kelimesi
            // Continue anahtar kelimesi

            /*for(int a=1; a<=10; a++)
            {
                if (a == 7)
                {
                    break;   // döngüyü kırıyor ve sonraki işlemlerin yapılmasını engelliyo.
                }

                Console.WriteLine("a'nın değeri :" +a);

            }

            Console.ReadLine(); */

            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue;  // döngüsü sadece 1 kereye mahsus kırıyor.
                }

                Console.WriteLine("a'nın değeri :" + a);

            }

            Console.ReadLine();
        }
    }
}
