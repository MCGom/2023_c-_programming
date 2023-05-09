using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5- i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < 2* i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int year = int.Parse(Console.ReadLine());

            if (year >= 3 && year <= 5)
            { Console.WriteLine("봄"); }
            else if (year >= 6 && year <= 8)
            { Console.WriteLine("여름"); }
            else if (year >= 9 && year <= 11)
            { Console.WriteLine("가을"); }
            else if (year <= 12 && year >= 1)
            { Console.WriteLine("겨울"); }
            else
            { Console.WriteLine("띠용"); }

        }
    }
}
