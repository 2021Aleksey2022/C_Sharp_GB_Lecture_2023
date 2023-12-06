using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2.Example004_MethodLibrary
{
    class Class1
    {
        Random rnd = new Random();
        void FillArray(int[] collection)
        {
            int lnght = collection.Length;
            int index = 0;
            while (index < lnght)
            {
               
                collection[index] = rnd.Next(1, 10);
                index++;
            }
        }
        void PrintArray(int[] col)
        {
            int count = col.Length;
            int position = 0;
            while (position < count)
            {
                System.Console.Write(col[position] + " ");
                position++;
            }
        }
        int IndexOffNumber(int[] collections, int find1)
        {
            int count = collections.Length;
            int index = 0;
            int position = -1;
            while (index < count)
            {
                if (collections[index] == find1)
                {
                    position = index;
                    break;
                }
                index++;
            }
            return position;
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Class1 class1 = new Class1();
            class1.FillArray(array);
            class1.PrintArray(array);
            Console.WriteLine();
            int pos = class1.IndexOffNumber(array, 4);
            Console.WriteLine(pos);


            Console.ReadLine();
        }   
    }
}
