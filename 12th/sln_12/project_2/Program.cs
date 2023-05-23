using System;


namespace project_2
{

    class Program
    {

        static void Change_A(int input)
        {
            input = 10;
            Console.WriteLine(input);
        }

        class Test
        {
            public int value = 20;
        }

        static void Change_B(Test input)
        {
            input.value = 30;
        }

        static void Main(string[] args)
        {
            int a1 = 40;
            Change_A(a1);//10
            Console.WriteLine(a1);//40

            int a2 = 50;
            int input = a2;
            input = 60;
            Change_A(a2); //50
            Test test = new Test();
            test.value = 65;
            Console.WriteLine(test.value);
            Change_B(test);
            Console.WriteLine(test.value);

        }
    }
}
