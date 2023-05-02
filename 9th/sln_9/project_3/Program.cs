using System;

namespace project_3
{
    class Program
    {
        class Cat
        {
            public string Name;
            public string Color;
            public int Age;
            public double Weight;

            public void meow()
            {
                Console.WriteLine($"{Name}: 야옹~");
            }

            public Cat(string name, string color, int age, double weight)//생성자
            {
                Name = name;
                Color = color;
                Age = age;
                Weight = weight;

            }
            public Cat()    //생성자(정의, 선언) : 객체 초기화
            {
                Name = "";
                Color = "";
                Age = 0;
                Weight = 0.0;
            }
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat("고냥이", "치즈", 2, 6.8);


            Console.WriteLine($"이름 : {cat.Name} \n색 : {cat.Color} \n나이 : {cat.Age} \n몸무게 : {cat.Weight}");
            
            Console.WriteLine();
            
            cat.meow();

        }
    }
}
