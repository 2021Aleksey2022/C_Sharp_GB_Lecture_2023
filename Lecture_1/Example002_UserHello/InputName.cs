using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1.Example002_UserHello
{
    class InputName
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string userName = Console.ReadLine();
            Console.Write("Привет, ");
            Console.Write(userName);
            Console.ReadLine();
        }
    }
}
