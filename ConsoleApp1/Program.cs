using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("White on blue.        " + typeof(ConsoleColor));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Another line.");
            Console.ResetColor();

            Console.WriteLine("Hello");
            Console.WriteLine("XXXXXXXXXXXXHelloXXXXXXXXXXXXXXX");
            Console.Read();
        }
    }
}
