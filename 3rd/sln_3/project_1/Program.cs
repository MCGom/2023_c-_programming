using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //복합대입 연산자
            /*int output = 0;
            output += 52;   //output = output + 52
            output += 273;

            Console.WriteLine(output);*/

            //+(문자열 연결 연산자)
            /*
            Console.WriteLine(10 + 10); //20
            Console.WriteLine(10 + "10");   //1010
            Console.WriteLine("소스" + "제어"); //소스제어
            Console.WriteLine(10 + 'a');    //107
            */

            //증감 연산자 -> 시험 나옴 ㅅㄱ
            /*
            int number1 = 10;
            number1++;
            Console.WriteLine(number1); //11
            number1--;
            Console.WriteLine(number1); //10

            int number2 = 20;
            Console.WriteLine(number2); //20
            Console.WriteLine(number2++);   //20 -> 21
            Console.WriteLine(number2--);   //21 -> 20
            Console.WriteLine(number2); //20

            int number3 = 50;
            Console.WriteLine(number3); //50
            number3++;
            number3++;
            Console.WriteLine(number3); //52
            

            int number4 = 65;
            Console.WriteLine(number4++);   //65 -> 66
            Console.WriteLine(--number4);   //65
            Console.WriteLine(number4++);  //65
            Console.WriteLine(++number4);   //67
            */

            //자료형
            /*
            int _int = 273;
            long _long = 522733103265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";
            

            //GetType() 메서드를 활용해서 자료형 출력
            
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
            */

            //직접적인 GetType() 메서드를 활용해서 자료형 출력
            Console.WriteLine((52.273F).GetType());

            //var 키워드
            //지역 변수로 선언 : 메서드 내부에 선언되어 있는 변수
            //메서드 외부에 var 키워드를 사용하면 -> 오류 발생
            //변수 선언과 동시에 초기화 선언

            var global = 52;
            var number = 100;




        }
    }
}
