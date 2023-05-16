using System;

namespace project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //속성(property)
            //은닉성과 편의성, 두 마리 토끼를 다 잡을 수 있는 방법

            BoxA boxA = new BoxA(10, 10);
            boxA.width = -10;
            Console.WriteLine(boxA.Area());

            Console.WriteLine();

            //BoxB boxB = new BoxB(10, 10);
            //boxB.width = -10;
            //Console.WriteLine(boxB.Area());
            
            BoxC boxC = new BoxC(10, 10);
            boxC.set_width(15);
            Console.WriteLine(boxC.Area());


        }
    }
}
