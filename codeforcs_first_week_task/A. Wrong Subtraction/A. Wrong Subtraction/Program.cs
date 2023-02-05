using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Wrong_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            for (int i = 0; i < b; i++)
            {
                if (a % 10 == 0)
                {
                    a /= 10;
                }
                else
                {
                    a--;
                }
            }
            Console.WriteLine(a);
           // Console.ReadKey();
        }
    }
}
