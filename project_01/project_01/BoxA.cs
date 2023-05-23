using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class BoxA
    {
        public int width;
        public int height;

        public BoxA(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area() //메서드 정의
        {
            return this.width * this.height; //this 안 붙여도 작동
        }


    }
}
