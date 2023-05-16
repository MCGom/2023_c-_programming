using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class BoxC
    {

        //겟터(Getter)와 셋터(Setter) : 변수를 바로 건드릴 수는 없지만 변수를 변경하는
        //메소드를 만들고 메소드를 호출해서 변경
        
        private int width;
        private int height;

        public BoxC(int width, int height) //생성자 정의
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

        public int get_width() { return width; }
        public int get_height() { return height; }

        public void set_width(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수로 입력해"); }
        }

        public void set_height(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수로 입력해"); }
        }

    }
}
