using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github");
        }
        //input: float x
        //output: smallest integral value that is not less than x
        //idea: a = (int)x then a = a + 1
        //if x is negative then a is unchanged
        //if x == a then a is unchanged
        public static int Ceil(float x)
        {
            int a = (int)x;
            if (x > 0)
            {
                if (x > a)
                {
                    a = a + 1;
                }
            }
            return a;
        }
        //input: float x
        //output: int a that is largest but not bigger than x
        //idea: a = (int)x
        //if x is negative then a = a - 1
        //if x == a then a is unchanged
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x != a)
                    a = a - 1;
            return a;
        }
    }
}
