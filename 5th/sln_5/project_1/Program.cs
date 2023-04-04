using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //짝수 홀수 구분
            //Console.Write("정수를 입력해주세요. : ");
            //string input = Console.ReadLine();
            //int output1 = int.Parse(input);
            /*
            int output2 = int.Parse(Console.ReadLine());

            if (output2 % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            
            if(output2 % 2 == 1)
            {
                Console.WriteLine("홀수입니다.");
            }
            */

            //if else 조건문
            /*
            int output2 = int.Parse(Console.ReadLine());

            if (output2 % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }
            */

            //switch 조건문

            /*
            int output = int.Parse(Console.ReadLine());

            switch (output % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다.");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다.");
                    break;
                default:
                    Console.WriteLine("이건 뭐징??");
                    break;
            }
            */

            //오전과 오후 구분하기

            /*
            if (DateTime.Now.Hour > 12)
            {
                Console.WriteLine("오후에오.");
            }
            else
            {
                Console.WriteLine("오전이에오.");
            }
            */

            //중첩 조건문
            /*
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹어라.");
            }
            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹으라고 했다.");
                }
                else
                {
                    Console.WriteLine("저녁이라도 먹으렴...");
                }
            }
            
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹어라.");
            }
            else if(DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹으라고 했다.");
            }
            else if(DateTime.Now.Hour < 21)
            {
                Console.WriteLine("저녁이라도 먹으렴...");
            }
            else
            {
                Console.WriteLine("야식... 먹을래...?");
            }
            */

            Console.Write("금액을 입력해주세요. : ");
            int money = int.Parse(Console.ReadLine());

            if (money >= 20000) { Console.WriteLine("탕수육"); }
            if (money >= 10000) { Console.WriteLine("쟁반짜장"); }
            if (money >= 7000) { Console.WriteLine("짬뽕"); }
            if (money >= 5000) { Console.WriteLine("짜장면"); }
            else { Console.WriteLine("단무지"); }
            
            Console.WriteLine();

            if (money >= 20000) { Console.WriteLine("탕수육"); }
            else if (money >= 10000) { Console.WriteLine("쟁반짜장"); }
            else if (money >= 7000) { Console.WriteLine("짬뽕"); }
            else if (money >= 5000) { Console.WriteLine("짜장면"); }
            else { Console.WriteLine("단무지"); }


        }
    }
}
