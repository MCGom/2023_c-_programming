using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //논리 연산자와 조건식
            /*
            Console.Write("학점을 입력하세요 : ");

            double score = double.Parse(Console.ReadLine());

            //score >= 4.0 && score < 4.5
            if (score == 4.5) { Console.WriteLine("만점자"); }
            else if (score >= 4.0 && score < 4.5) { Console.WriteLine("A+"); }
            else if (score >= 3.5 && score < 4.0) { Console.WriteLine("A"); }
            else if (score >= 3.0 && score < 3.5) { Console.WriteLine("B+"); }
            else if (score >= 2.5 && score < 3.0) { Console.WriteLine("B"); }
            else if (score >= 2.0 && score < 2.5) { Console.WriteLine("C+"); }
            else if (score >= 1.5 && score < 2.0) { Console.WriteLine("C"); }
            else if (score >= 1.0 && score < 1.5) { Console.WriteLine("D+"); }
            else if (score >= 0.5 && score < 1.0) { Console.WriteLine("D"); }
            else if (score >= 0) { Console.WriteLine("F"); }
            else { Console.WriteLine("마이너스 학점이 어딨니ㅋㅋㅋㅋ"); }
            */

            /*
            //조건문 간단히 사용하기
            //if else 조건문은 이전에 비교했던 것이 자동으로 걸러지므로
            //이전에 비교했던 것을 다시 비교할 필요가 없다.

            Console.Write("학점을 입력하세요 : ");
            
            double score = double.Parse(Console.ReadLine());

            //score >= 4.0 && score < 4.5
            if (score > 4.5) { Console.WriteLine("4.5를 넘기다니 넌 대학생이 맞는 거니"); }
            else if (score == 4.5) { Console.WriteLine("만점자"); }
            else if (score >= 4.0) { Console.WriteLine("A+"); }
            else if (score >= 3.5) { Console.WriteLine("A"); }
            else if (score >= 3.0) { Console.WriteLine("B+"); }
            else if (score >= 2.5) { Console.WriteLine("B"); }
            else if (score >= 2.0) { Console.WriteLine("C+"); }
            else if (score >= 1.5) { Console.WriteLine("C"); }
            else if (score >= 1.0) { Console.WriteLine("D+"); }
            else if (score >= 0.5) { Console.WriteLine("D"); }
            else if (score >= 0) { Console.WriteLine("F"); }
            else { Console.WriteLine("마이너스 학점이 어딨니ㅋㅋㅋㅋ"); }
            */

            /*
            //삼항연산자

            int num = int.Parse(Console.ReadLine());

            //참과 거짓 위치에 불 자료형 사용

            Console.WriteLine(num % 2 == 0 ? true : false);

            //참과 거짓 위치에 문자열 자료형 사용

            Console.WriteLine(num % 2 == 0 ? "뭐" : "훗");

            //삼항연산자를 이용한 자연수 판별
            Console.WriteLine(num > 0 ? "Nature" : "That's nono");
            */

            /*
            //switch 
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    break;
            }
            */

            //break 키워드를 사용하지 않는 switch 조건문
            
            Console.Write("이번 달은 몇 월 인가용???????:::::");

            int input = int.Parse(Console.ReadLine());
            /*
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("춥겠당...ㅎㅎ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("개학...했겠네...?");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("덥겠당ㅋㅋㅋㅋ");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을 좋아ㅎㅎ");
                    break;
                default:
                    Console.WriteLine("미치셨습니까? 휴먼?");
                    break;
            }
            */

            if(input > 12 || input < 1)
            {
                Console.WriteLine("미치셨습니까? 휴먼?");
            }
            else if (input >= 3 && input <= 5)
            {
                Console.WriteLine("개학...했겠네...?");
            }
            else if(input >= 6 && input <= 8)
            {
                Console.WriteLine("덥겠당ㅋㅋㅋㅋ");
            }
            else if(input >= 9 && input <= 11)
            {
                Console.WriteLine("가을 좋아ㅎㅎ");
            }
            else
            {
                Console.WriteLine("춥겠당...ㅎㅎ");
            }

        }
    }
}
