using System;
using System.Collections.Generic;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //클래스 구현 부분의 코드 중복 해결
            List<Animal> Animals = new List<Animal>() {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                //☆is 키워드를 사용하는 경우의 일반적인 자료형 변환
                if(item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }
                Console.WriteLine("---");

                //as 키워드를 이용한 자료형 변환
                if (item is Dog) { (item as Dog).Bark(); }
                if (item is Cat) { (item as Cat).Meow(); }
                Console.WriteLine("---");

                //is: 객체가 해당하는 형식에 해당하는 지를 검사하여 그 결과를 bool 값으로 반환
                //as: 형식변환 연산자와 같은 역할을 한다.
                //  is는 형변환 연산자가 변환에 실패하는 경우 예외를 던지는 반면
                //  as 연산자는 객체 참조를 null로 만든다.

                //as 키워드를 사용하는 경우의 일반적인 형태
                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if(cat != null) { cat.Meow(); }

            }


        }
    }
}
