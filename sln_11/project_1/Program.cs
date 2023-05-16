using System;

namespace project_1
{
    class Program
    {

        class MyMath
        {
            public static int Abs(int input)
            {
                
                if(input < 0)
                {
                    return -input;
                }
                return input;
            }

            public static double Abs(double input)
            {

                if (input < 0)
                {
                    return -input;
                }
                return input;
            }

            public static long Abs(long input)
            {

                if (input < 0)
                {
                    return -input;
                }
                return input;
            }
        }

        static void Main(string[] args)
        {
            //메소드 오버로딩 : 하나의 메소드 이름에 여러 개의 구현을 올리는 것


            //int
            Console.WriteLine(MyMath.Abs(-50));
            Console.WriteLine(MyMath.Abs(300));

            Console.WriteLine();

            //double
            Console.WriteLine(MyMath.Abs(-7.85));
            Console.WriteLine(MyMath.Abs(9.15));

            Console.WriteLine();

            //long
            Console.WriteLine(MyMath.Abs(2147836470));
            Console.WriteLine(MyMath.Abs(-2147836470));



        }
    }
}
