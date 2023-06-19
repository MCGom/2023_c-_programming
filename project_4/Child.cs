using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    class Child : Parent
    {
        public Child() : base()
        {
            Console.WriteLine("자식 생성자");
        }
    }
}
