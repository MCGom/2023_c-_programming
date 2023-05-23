using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class BoxB
    {
        //캡슐화: 너비 높이 못건드림
        private int width;
        private int height;

        public BoxB(int width, int height)
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
