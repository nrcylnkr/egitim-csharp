using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_erisim_belirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // public - private - protected - internal    Birşeye erişmek için koyduğumuz kısıtlamalar.


            Musteri costumer1 = new Musteri();

            costumer1.name = "Enes";
            costumer1.surname = "Özdemir";
            costumer1.salary = 7200;
            costumer1.sex = "Male";

            costumer1.show_costumer_info();

        }
    }
}
