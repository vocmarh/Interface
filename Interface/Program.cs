using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(a);
            arithProgression.getNext();
            arithProgression.reset();

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(a);
            geomProgression.getNext();
            geomProgression.reset();
            Console.ReadKey();

        }
    }
    interface ISeries
    {
        void setStart(int x);
        void getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        public int d = 2;
        public int a = 10;
        public int t = 2;
        public void setStart(int x)
        {
            Console.WriteLine(x);
        }
        public void getNext()
        {
            for (int i = 2; i <= t; i++)
            {
                Console.WriteLine(a + (i - 1) * d);
            }
        }
        public void reset()
        {
            for (int i = 1; i <= (t-1); i++)
            {
                Console.WriteLine(a + (i - 1) * d);
            }
        }        
    }
    class GeomProgression : ISeries
    {
        public int d = 2;
        public int a = 10;
        public int t = 2;
        public void setStart(int x)
        {
            Console.WriteLine(x);
        }
        public void getNext()
        {
            for (int i = 2; i <= t; i++)
            {
                Console.WriteLine(a * (i - 1) * d);
            }
        }
        public void reset()
        {
            for (int i = 1; i <= (t - 1); i++)
            {
                Console.WriteLine(a);
            }
        }
    }

}   
