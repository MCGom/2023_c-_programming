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

        public BoxA(int width, int height) //생성자 정의
        {
            this.width = width;
            this.height = height;
        }

        public int Area() //메소드 정의
        {
            return width * height;
        }
    }
}
