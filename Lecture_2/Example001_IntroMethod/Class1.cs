using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2.Example001_IntroMethod
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a1 = 15;
            int b1 = 21;
            int c1 = 39;
            int a2 = 12;
            int b2 = 23;
            int c2 = 33;
            int a3 = 13;
            int b3 = 43;
            int c3 = 333;

            int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

            Console.WriteLine(max);
            Console.ReadLine();
        }
        static int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;
            if (arg2 > result) result = arg2;
            if (arg3 > result) result = arg3;
            return result;
        }
    }
}
