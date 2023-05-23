using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    class Cat
    {
        public string Name; //필드(변수)
        public string Color;
        public int Age;


        public void Meow() //메서드
        {
            Console.WriteLine($"{Name}: 냥");
            Console.WriteLine("냥이가 생성됐어용★");
        }

        public Cat() //생성자
        {
            Name = "";
            Color = "";
        }

        public Cat(string name, string color, int age) //생성자
        {
            Name = name;
            Color = color;
            Age = age;
        }
    }
}
