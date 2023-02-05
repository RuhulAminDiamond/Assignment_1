using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWay_Too_Long_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());    
            for(int i=1;i<=n; i++) { 
                string s = Console.ReadLine();
                if (s.Length <= 10)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine(s[0] + "" + (s.Length-2) +""+ s[s.Length-1]);
                   // Console.WriteLine(s[0] + s.Length - 2 + s[s.Length-1]);
                }
            
            
            }
        }
    }
}
