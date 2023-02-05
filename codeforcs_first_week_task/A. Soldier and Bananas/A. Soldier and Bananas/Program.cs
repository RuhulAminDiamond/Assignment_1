using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Soldier_and_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, w;
           
            string[] s = Console.ReadLine().Split(new char[] {' '});

            k = int.Parse(s[0]);
            n = int.Parse(s[1]);
            w = int.Parse(s[2]);
            int sum = 0;
            for(int i = 1; i <= w; i++)
            {
                sum += (i*k);
            }
            if (n > sum)
            {
                sum = 0;
                Console.WriteLine(sum); 
            }
            else
            {
                Console.WriteLine(Math.Abs(sum - n));
            }
           
           // Console.ReadKey();

        }
    }
}
