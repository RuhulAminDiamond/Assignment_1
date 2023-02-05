using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Petya_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, ss;
            s = Console.ReadLine();
            ss = Console.ReadLine();
            //s.ToLower();
            //ss.ToLower();
            int d = s.ToLower().CompareTo(ss.ToLower());
            Console.WriteLine(d);
            //Console.ReadKey();
        }
    }
}
