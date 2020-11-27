using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork_6
{
    public class UsefullMethods
    {
        public static void print(string s, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }
        public static void pause()
        {
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }
    }
}
