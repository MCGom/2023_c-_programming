using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class Dog : Animal
    {
        //속성(프로퍼티)
        public string Color { get; set; }

        //메서드
        public void Bark() { Console.WriteLine("왈왈"); }

    }
}
