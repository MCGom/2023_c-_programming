using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //무한 반복
            /*
            for (; ;)
            {
                Console.WriteLine("무한 루프");
            }

            */
            /*
            while(true)
            {
                Console.WriteLine("무한 루프");
            }
            

            //for 반복문 덧셈
            int output = 0;
            for (int i = 1; i <= 100; i++)
            {
                output += i;
            }
            Console.WriteLine(output);
            
            //for 반복문 곱셈
            int output = 1;
            for (int i = 1; i <= 10; i++)
            {
                output *= i;
            }
            Console.WriteLine(output);
            

            //역 for 문
            int[] int_array = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = int_array.Length -1 ; i >= 0 ; i--)
            {
                Console.WriteLine(int_array[i]);
            }

            string[] array = { "사과", "배", "바나나", "수박","복숭아" };
            foreach (var item in array)
            {
                Console.Write(item);
            }
*/
            //while 반복문
            int i = 0;
            int[] array = {27, 31, 4, 88, 91, 56 };
            while(i < array.Length)
            {
                Console.WriteLine((i + 1) + " 번째 출력 : " + array[i]);
                i++;
            }

            Console.WriteLine();

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine((j + 1) + " 번째 출력 : " + array[j]);
            }

        }
    }
}
