using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class BoxB
    {
        //캡슐화 변수와 메소드를 건드리지 못하게 막음
        private int width;
        private int height;

        private BoxB(int width, int height) //생성자 정의
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해주세요.");
            }
        }


        public int Area() //메소드 정의
        {
            return width * height;
        }
    }
}
