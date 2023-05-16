using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MainApp.Plus(5, 8));
            Console.WriteLine(MainApp.Plus(5, 8, 6));
            Console.WriteLine(MainApp.Plus(5.3, 8.9));
            Console.WriteLine(MainApp.Plus(5.1, 8.4, 4.5));
            Console.WriteLine(MainApp.Plus(5, 8.4));



        }
    }
}
