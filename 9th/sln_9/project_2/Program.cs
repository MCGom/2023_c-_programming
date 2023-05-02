using System;
using System.Collections.Generic;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble() * 10);

            //배열 생성

            int[] array_1 = new int[10];

            //List 클래스의 인스턴스 생성

            List<int> list_1 = new List<int>();

            list_1.Add(51);

            List<int> list_2 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            list_2.Remove(6);
            list_2.Insert(4, 7);

            foreach (var item in list_2)
            {
                Console.WriteLine("count : " + item);
            }

            //Math 클래스

            Console.WriteLine(Math.Abs(-22222));



        }
    }
}
