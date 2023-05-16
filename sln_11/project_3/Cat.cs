using System;

namespace project_3
{
    class Cat
    {
        

        public string name;
        public string color;
        public int age;

        public void Meow() //메서드
        {
            Console.WriteLine("{0}({1}세 {2} 냥이) : 냐옹", name, age, color);
        }

        public Cat() //생성자
        {
            name = "";
            color = "";
            age = 0;

        }

        public Cat(string name, string color, int age)//생성자
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }


    }
}
