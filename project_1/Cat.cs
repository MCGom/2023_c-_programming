using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Cat
    {
        //속성(프로퍼티)
        public int Age { get; set; }

        //생성자
        public Cat() { this.Age = 0; }

        //메서드
        public void Eat() { Console.WriteLine("냠냠"); }
        public void Sleep() { Console.WriteLine("쿨쿨"); }
        public void Meow() { Console.WriteLine("냥냥"); }
    }
}
