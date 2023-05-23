using System;

namespace project_11
{
    class Program
    {
        class Mymath
        {
            public static int Abs(int input)
            {
                if(input < 0) { return -input; }
                else { return input; }
            }

            public static double Abs(double input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }

            public static long Abs(long input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }

        static void Main(string[] args)
        {
            //메서드 오버로딩: 하나의 메서드 이름에 여러 개의 구현을 올리는 것

            //int
            Console.WriteLine(Mymath.Abs(-52));
            Console.WriteLine(Mymath.Abs(252));
            Console.WriteLine();

            //double
            Console.WriteLine(Mymath.Abs(-52.123));
            Console.WriteLine(Mymath.Abs(252.123));
            Console.WriteLine();

            //long
            Console.WriteLine(Mymath.Abs(21474836470));
            Console.WriteLine(Mymath.Abs(-21474836470));
            Console.WriteLine();
        }
    }
}
