using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2.Example002_IntroArray
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 21, 133, 42, 57, 56, 79, 38, 89 };

            array[0] = 12;
            Console.WriteLine(array[3]);

            int result1 = Max(Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
            Console.WriteLine(result1);
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
