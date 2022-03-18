using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_kapsulleme_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TC_Kimlik personel = new TC_Kimlik();

            //personel.tc_no = Console.ReadLine();
            personel.tc_no = "12345678912";

            Console.WriteLine("TC Kimlik Numaranız : " + personel.tc_no);
            Console.ReadLine();

        }
    }
}
