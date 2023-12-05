using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2.Example004_MethodLibrary
{
    class Class1
    {
        void FillArray(int[] collection)
        {
            int lnght = collection.Length;
            for(int index = 0; index < lnght; index++){
                collection[index] = new Random().Next(1, 10);
            }
            
        }
        void PrintArray(int[] col)
        {
            int count = col.Length;
            for(int position = 0; position < count; position++)
            {
                Console.Write(col[position]);

            }
          
        }
        int IndexOffNumber(int[] collections, int find1)
        {
            int count = collections.Length;
            int index = 0;
            int position = 0;
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
        static int[] array = new int[10];
        static void Main(string[] args)
        {
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
