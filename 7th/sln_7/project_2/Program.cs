using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //중첩 반복문: 구구단

            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("*" + i + "단" + "*");
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " × " + j + " = " + (i*j));
                }
                Console.WriteLine();
            }
            

            //★시험: 별그리기
            // 중첩 반복문: 별 피라미드(1)
            for (int i = 1; i <= 10; i++) //(i = 0; i < 10 ...)
            {
                for (int j = 0; j < i; j++) //(j = 0; j < i+1 ...)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //별 피라미드(2)
            for (int n = 1; n <= 10; n++)
            {
                for (int j = 0; j < 10 - n; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < n; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            
            //별 피라미드(3)
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }

                for (int n = 0; n < i; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            */

            //
            int i, j, sp = 8;

            for (i = 1; i <= 9; i++)
            {
                for (j = sp; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                
                for (j = 1; j <= i; j++)
                {
                    //Console.Write(i + "");
                    Console.Write(i + " ");
                    //Console.Write("" + i);
                    //Console.Write(" " + i);
                }
                Console.WriteLine();
                sp--;
            }


        }
    }
}
