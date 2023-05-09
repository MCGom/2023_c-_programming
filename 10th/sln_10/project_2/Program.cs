using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            Console.WriteLine(test.Power(4)); 

            //Console.WriteLine(Test.Power(20)); static 있을 때
            
            Console.WriteLine();

            int resultA = Calcurator.Plus(3, 4);
            int resultB = Calcurator.Minus(37582, 5349);

            Console.WriteLine(resultA);
            Console.WriteLine(resultB);

            Console.WriteLine();

            Console.WriteLine(MyMath.Abs(-55));
            Console.WriteLine(MyMath.Abs(66));

            //MyMath mymath = new MyMath();

            //Console.WriteLine(mymath.Abs(-888));

        }
    }
}
