using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Stones_on_the_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cnt = 0;
            string s;
            n = int.Parse(Console.ReadLine());
            s = Console.ReadLine();
            for(int i=0; i<n-1; i++) {
                if (s[i] == s[i + 1]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
           // Console.ReadKey();
        }
    }
}
