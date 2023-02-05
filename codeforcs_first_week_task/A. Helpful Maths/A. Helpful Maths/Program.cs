using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Helpful_Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split('+').ToArray();
         
           Array.Sort(s);
            /*              
              string final = string.Join("+", s);
              auto suggested by visual stdio .
            */
            string result = string.Empty;
            for(int i = 0; i < s.Length; i++)
            {
                if(i <(s.Length)-1)
                {
                    result += s[i]+"+";
                }else
                {
                    result += s[i];
                }

            }
            Console.WriteLine(result);
            
            //Console.ReadKey();
        }
    }
}
