using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A.Beautiful_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] s = new int[6,6];
            for(int i = 0; i < 5; i++)
            {
                string[] d = Console.ReadLine().Split(' ');

                for (int j = 0;j < 5; j++)
                {
                    s[i,j] = int.Parse(d[j]);
                }
               // Console.ReadLine(s[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (s[i, j] == 1) 
                    {
                        Console.WriteLine(Math.Abs(i-2)+ Math.Abs(j-2));
                       
                        //Console.ReadKey(); 

                    }

                }
                //Thread.Sleep(1000);
                //Console.WriteLine();
                // Console.ReadLine(s[i]);
            }
           // Console.ReadKey();
        }
    }
}
