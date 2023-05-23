using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MainApp.Plus(1, 2));
            Console.WriteLine(MainApp.Plus(1, 2, 3));
            Console.WriteLine(MainApp.Plus(1.0, 2.0));
            Console.WriteLine(MainApp.Plus(1.0, 2.0, 3.0));
        }
    }
}
