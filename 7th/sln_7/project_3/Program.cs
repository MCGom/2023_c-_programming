using System;
using System.Threading;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //break 키워드
            while (true)
            {
                Console.WriteLine("숫자를 입력해 주세요(짝수를 입력하면 종료): ");

                int input = int.Parse(Console.ReadLine());

                if (input % 2 != 0)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break;
                }
                Console.WriteLine();
            }
            

            //continue
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                //Console.WriteLine(i);
                Console.WriteLine($"{i} : 홀수");
            }
            */

            //Thread.Sleep() 메서드
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1500);

            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1500);

            Console.WriteLine("세 번째 출력");
        }
    }
}
