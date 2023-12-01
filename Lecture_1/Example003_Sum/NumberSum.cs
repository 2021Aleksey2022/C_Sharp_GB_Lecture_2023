using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1.Example003_Sum
{
    class NumberSum
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1, 10);
            Console.WriteLine($"Первое число: {numberA}");
            int numberB = new Random().Next(0, 20);
            Console.WriteLine($"Второе число: {numberB}");
            int result = numberA + numberB;
            Console.WriteLine($"Сумма чисел: {result}");
            Console.ReadLine();
        }
    }
}
