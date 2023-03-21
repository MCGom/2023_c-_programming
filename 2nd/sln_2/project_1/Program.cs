using System;
using static System.Console;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("헬로우 월드");
            Console.WriteLine("C# 프로그래밍");
            Console.Write("실습");
            Console.Write("화이팅");
            WriteLine("소프트웨어");
            Console.WriteLine(10/2+30*3);


            // 기본 자료형 : 정수
            Console.WriteLine(50 + 273);
            Console.WriteLine(10 / 2);
            Console.WriteLine(10 % 3); 

            // 연산자의 부호
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);

            // 실수
            Console.WriteLine(12.5 + 65.7);
            Console.WriteLine(12.0 + 15.0);
            Console.WriteLine(5.0 % 2.2); //실수는 나머지 연산자 사용안함

            // 문자, 문자열
            Console.WriteLine('문');
            Console.WriteLine("문자열");


            // 문자열 연결 연산자 (+)
            Console.WriteLine("가나다" + "라마" + "바사아");
            Console.WriteLine(253 + "가나"); 

            // 문자 선택 괄호
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("안녕하세요."[3]); //세
            // Console.WriteLine("안녕하세요."[6]); //오류
            Console.WriteLine("안녕하세요."[5]); 

            // 불 : 참과 거짓을 표현할 때 사용(불과 비교 연산자)
            Console.WriteLine(52 == 273);
            Console.WriteLine(52 < 273); // < 작다
            Console.WriteLine(52 > 273); // > 크다 */

            // 논리 연산자(논리부정 !, 논리합 ||, 논리곱 &&)
            Console.WriteLine(!true);
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Hour < 3 && 8 < DateTime.Now.Hour);

            
            //변수 : 값을 저장할 때 사용하는 식별자
            //정수 자료형 (int, long)
            int a = 123;
            int b = 52;
            Console.WriteLine(a % b);

            //실수 자료형 (float 4, double 8)
            double aa = 52.273;
            double bb = 103.32;
            Console.WriteLine(52.123f + 12.34f);    //결과값 float
            Console.WriteLine(52.123 + 12.34f);    //결과값 double

            //sizeof(자료형), 자료형의 크기를 확인한다
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));
            //Console.WriteLine("string : " + sizeof(string));
            //다른 자료형은 모두 구조체이지만 string 자료형은 class이다. class는 메모리 공간에 없기 때문에 크기를 확인할 수 없다.




        }

    }
}
