using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 서식 맞추기 -> 시험에 나옴 ㅅㄱ
            //console.WriteLine(""); -> 기본적으로 문자열을 출력하는 메소드
            //숫자를 출력할 때는 문자열로 변환하는 과정이 필요
            //C#은 문자열 서식화에 사용할 수 있는 간편한 방법 두 가지를 제공
            //① string 형식의 Format() 메서드
            //② 문자열 보간(Interpolation)
            /*
            Console.WriteLine("제목 : " + "컴소공");

            //① string 형식의 Format() 메서드
            Console.WriteLine("제목 : {0}", "컴소공");


            //② 문자열 보간(Interpolation)
            Console.WriteLine($"제목 : {"컴소공"}");

            Console.WriteLine("{0}, {1}, {2}", 123, "최강컴소과", 52.273F);  //string 형싱의 Format()
            Console.WriteLine($"{123}, {"최강컴소과"}, {52.273F}");  //문자열 보간
            */

            //{0, 맞춤, 서식 문자열} -> string 형식의 Format()

            Console.WriteLine("Total : {0, 7:D}", 255); //첨자 : 0, 맞춤 : 7, 서식 문자열 : D(십진수)
            Console.WriteLine("Total : {0, -7:D}", 255);

            Console.WriteLine("{0, -10:D5}", 123);
            Console.WriteLine($"{123,-10:D5}");

            int n = 123;
            string s = "최강 컴소과";
            Console.WriteLine("{0}, {1}", n, s);
            Console.WriteLine($"{n}, {s}");

            string fmt = "{0, -20}, {1, -15}, {2, 30}";

            Console.WriteLine(fmt, "Yuhan", "Computer", "Programming");

        }
    }
}
