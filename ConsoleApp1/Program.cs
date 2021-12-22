using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();
            task.setStart(10);
            task.getNext();
            Console.ReadKey();
        }

    }
    class Task
    {        
        public void setStart(int x)
        {            
        }
        public int getNext()
        {
            return y = x+d;
            Console.WriteLine(y);
        }
        public void reset()
        {
            Console.WriteLine(x);
        }
    }
}
