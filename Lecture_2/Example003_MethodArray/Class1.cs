using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2.Example003_MethodArray
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] array = { 13, 28, 57, 13, 34, 56, 46, 57, 28, 91 };

            int n = array.Length;

            int find = 57;
            int find1 = 34;
            int index = 0;
            while(index < n)
            {
                if(array[index] == find)
                {
                    Console.WriteLine($"{index}");
                    break;
                }              
                index++;
            }
            Console.ReadLine();
        }
    }
}
