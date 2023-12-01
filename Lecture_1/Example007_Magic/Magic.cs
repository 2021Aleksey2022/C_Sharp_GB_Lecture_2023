using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1.Example007_Magic
{
    class Magic
    {
        static void Main(string[] args)
        {
            int xa = 20, ya = 1, xb = 1, yb = 30, xc = 40, yc = 30;
            Console.SetCursorPosition(xa, ya);
            Console.Write("+");
            Console.SetCursorPosition(xb, yb);
            Console.Write("+");
            Console.SetCursorPosition(xc, yc);
            Console.Write("+");

            int x = xa, y = xb;
            int count = 0;
            while (count < 10000)
            {
                int what = new Random().Next(0, 3);
                if (what == 0)
                {
                    x = (x + xa) / 2;
                    y = (y + ya) / 2;
                }
                else if (what == 1)
                {
                    x = (x + xb) / 2;
                    y = (y + yb) / 2;
                }
                else
                {
                    x = (x + xc) / 2;
                    y = (y + yc) / 2;
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+");
                count++;
            }
            Console.ReadLine();
        }
    }
}
