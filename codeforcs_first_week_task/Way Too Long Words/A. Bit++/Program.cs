using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int cnt = 0;
            while(n > 0) {
                n--;
                string s;
                s = Console.ReadLine();
                if (s.Contains('+'))
                {
                    cnt++;
                }
                else if (s.Contains('-'))
                {
                    cnt--;
                }
            }
            Console.WriteLine(cnt);
           // Console.ReadKey();
                    
        }
    }
}
