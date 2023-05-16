using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 접근 제한자(한정자)
             * 객체지향 프로그래밍은 클래스의 사용자에게 필요한 최소한의
             * 기능만을 노출하고, 내부를 감출 것을 요구한다.
             * 이것을 은닉성이라 한다.
             * ※ C#에서 제공하는 접근 제한자
             * public : 클래스의 내부/외부 모든 곳에서 접근 가능
             * protected : 클래스의 외부에서는 접근할 수 없지만 파생 클래스에서는 접근 가능
             * private : 클래스의 내부에서만 접근 가능
             * internal : 같은 어셈블리에 있는 코드에서만 public으로 접근 가능
             * protected internal
             * private protected
             */

            //생성자
            //왜 필요한가. 임무는 단 하나 -> 해당 형식(클래스)의 객체를 생성하는 것
            //객체의 필드를 원하는 값으로 초기화하기 위해서


            Cat kitty = new Cat("강아지", "치즈", 6);

            kitty.Meow();

            Console.WriteLine($"{kitty.name}({kitty.age}세 {kitty.color}) : 밥");

            Console.WriteLine();

            Cat cat = new Cat("햄스터", "갈색", 8);

            cat.Meow();

            Console.WriteLine($"{cat.name}({cat.age}세 {cat.color}) : 줘");

            Console.WriteLine();

            Cat chicken = new Cat("치킨", "황금색", 2);

            chicken.Meow();

            Console.WriteLine($"{chicken.name}({chicken.age}세 {chicken.color}) : 냥");

        }
    }
}
