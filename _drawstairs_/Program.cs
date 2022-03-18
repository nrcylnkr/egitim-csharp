using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _drawstairs_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(draw_stairs(7));
            Console.ReadLine();
        }

        static string draw_stairs(int n)
        {
            string empty = " ";
            string x = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                x += "I\n" + empty;
                empty += " ";
            }
            return x.Trim();
        }
    }
}
