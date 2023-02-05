using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.HQ9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Contains('H')|| s.Contains('Q')||s.Contains('9')) //||s.Contains('+'))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //Console.ReadKey();
        }
    }
}
