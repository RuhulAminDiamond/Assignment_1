using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace A.String_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = s.ToLower();
           string d = string.Empty;
            for(int  i=0;i<result.Length; i++)
            {
                if (result[i]=='a'||result[i]=='y' ||result[i] == 'e' || result[i] == 'i' || result[i] == 'o' ||  result[i] == 'u')
                {
                    continue;
                }
                else
                {
                    d += "." + result[i];
                }
            }
            Console.WriteLine(d);
            //   // string result = new string(s.Where(c => !c.IsVowel()).ToArray());
            //var letters = new HashSet<char>(s);
            // letters.ExceptWith("AaEeIiOoUu");
            //Console.WriteLine(letters);
           // Console.ReadKey();

        }
    }
}
