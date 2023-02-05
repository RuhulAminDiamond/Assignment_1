using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int cnt = 1;
            bool target = false;
            for(int i=0;i<s.Length-1;i++)
            {
                if (s[i] == s[i + 1])
                {
                    cnt++;
                }else {
                    cnt = 1;
                }
                if (cnt == 7)
                {
                    target= true;
                    break;
                }
            }if(target)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
           // Console.ReadKey();
        }
    }
}
