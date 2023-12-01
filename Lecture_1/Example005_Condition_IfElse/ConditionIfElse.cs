using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1.Example005_Condition_IfElse
{
    class ConditionIfElse
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string userName = Console.ReadLine();
            if (userName.ToLower() == "маша")
            {
                Console.WriteLine("Ура, это же Маша!");
            }
            else
            {
                Console.Write("Привет, ");
                Console.WriteLine(userName);
            }
            Console.ReadLine();
        }
    }
}
