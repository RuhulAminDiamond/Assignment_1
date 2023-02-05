using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Bear_and_Big_Brother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(new char[] { ' ' });
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int cnt = 0;
            while(a <= b)
            {
                
                a*=3; b*=2; cnt++;
            }
            Console.WriteLine(cnt);
           // Console.ReadKey();
        }
    }
}
