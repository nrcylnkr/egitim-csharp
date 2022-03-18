using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_karar_yapilari_if_else_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // öğrencinin notu 50 den büyükse başarılı, değilse başarısız yazdıran program çıktısını kodlayınız.

            int not = 75;    // burada  doğru olduğu içim if komut satırı çalışır.

            //int not = 40;   // burada yanlış olduğu için else komut satırı çalışır.

            if (not > 50)    
              
            {
                Console.WriteLine("öğrenci bu dersten başarılı bir şekilde geçmiştir");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("dersten başarısız oldunuz");
                Console.ReadLine();
            }


        }
    }
}
