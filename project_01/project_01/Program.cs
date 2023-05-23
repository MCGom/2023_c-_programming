using System;

namespace project_01
{

    //클래스의 구성 : 필드(변수), 메소드, 생성자, 속성
    class Program
    {
        static void Main(string[] args)
        {
            //속성(property)
            //은익성과 편의성, 두 마리 토끼를 다 잡을 수 있는 방법

            BoxA boxA = new BoxA(10, 10);
            boxA.width = -10;
            Console.WriteLine(boxA.Area());
            Console.WriteLine();

            /*BoxB boxB = new BoxB(10, 10);
            //boxB.width = -10;
            Console.WriteLine(boxB.Area());*/

            BoxC boxC = new BoxC(10, 10);
            //boxC.width = -10;
            Console.WriteLine(boxC.Area());
            Console.WriteLine();

            BoxD boxD = new BoxD(10, 10);
            //boxC.width = -10;
            boxD.Height = -15;
            Console.WriteLine(boxD.Area());
            Console.WriteLine();

            Console.WriteLine(boxD.Width);
            Console.WriteLine(boxD.Height);

            Console.WriteLine();

            BoxE boxE = new BoxE(10, 10);
            //boxC.width = -10;
            boxE.Height = -15;
            Console.WriteLine(boxE.Area());
            Console.WriteLine();


        }
    }
}
