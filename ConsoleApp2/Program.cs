using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int d = 2;
            int t = 10;
            

            for (int i = 1; i <= t; i++)
            {
                Console.WriteLine(a + (i - 1) * d);
                
            }

            Console.ReadKey();

            
        }
    }
}
