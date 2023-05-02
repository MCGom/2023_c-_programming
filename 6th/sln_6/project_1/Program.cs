using System;
using System.Collections.Generic;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //반복문과 배열
            /*
            Console.WriteLine("Output");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Output");
            }

            */

            /*
            //int score = 60; 변수
            int[] score = new int[5];
            score[0] = 80;
            score[1] = 70;
            score[2] = 90;
            score[3] = 40;
            score[4] = 20;

            //int[] scores = new int[5] { 80, 70, 90, 40, 20 };
            //int[] scores = new int[] { 80, 70, 90, 40, 20 };
            //int[] scores = { 80, 70, 90, 40, 20 };
            

            int[] score = { 80, 90, 10, 70, 20 };

            foreach (var value in score)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            int sum = 0 ;

            foreach (var value in score)
            {
                sum += value;
            }
            Console.WriteLine(sum);

            //int avg = sum / 5;
            int avg = sum / score.Length;

            Console.WriteLine(avg);
*/
            int[] score_1 = new int[5] { 90, 70, 10, 40, 50 };
            //new == 메모리 할당 연산자

            //원하는 크기의 배열 선언 방법

            int[] int_array = new int[100];
            Console.WriteLine(int_array[0]); //일반적인 숫자 자료형은 0으로 초기화
            List<int> int_list = new List<int>();

            char[] char_array = new char[100];
            Console.WriteLine(char_array[0]);//문자형 자료형은 빈 문자로 초기화

            //Console.WriteLine(score_1[5]);
            //Console.WriteLine(score_1[-4]);
            Console.WriteLine(score_1.Length);


        }

    }
}
