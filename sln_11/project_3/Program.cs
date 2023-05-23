using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*접근 제한자(한정자)
            객체지향 프로그래밍은 클래스의 사용자에게 필요한 최소한의
            기능만을 노출하고, 내부를 감출 것을 요구한다.
            이것을 은익성이라고 한다.
            ※ C#에서 제공하는 접근 제한자
            public: 클래스의 내부/ 외부 모든 곳에서 접근 가능
            protected: 클래스의 외부에서 접근할 수 없지만 파생 클래스에서만 접근 가능
            private: 클래스의 내부에서만 접근 가능
            internal: 같은 어셈블리에 있는 코드에서만 public으로 접근 가능
            protected internal
            private internal
            */

            //생성자
            //왜 필요할까? 임무는 단 하나 -> 해당 형식(클래스)의 객체를 생성하는 것
            //객체의 필드(변수)를 원하는 값으로 초기화하고 싶을 때

            Cat kitty = new Cat("라쿤", "치즈", 2);
            kitty.Meow();
            Console.WriteLine($"{kitty.Name}({kitty.Color}, {kitty.Age}살)");
            Console.WriteLine();

            Cat nero = new Cat("네로네로", "하바네로", 322);
            nero.Meow();
            Console.WriteLine($"{nero.Name}({nero.Color}, {nero.Age}살)");
            Console.WriteLine();

            Cat mya = new Cat("먀아", "먀먀", 322222);
            mya.Meow();
            Console.WriteLine($"{mya.Name}({mya.Color}, {mya.Age}살)");
            Console.WriteLine();
        }
    }
}
