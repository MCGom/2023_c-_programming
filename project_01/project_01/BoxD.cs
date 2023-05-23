using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class BoxD
    {
        private int width; //변수

        public int Width //속성
        {
            get { return width; }
            set
            {
                if (value < 0) { Console.WriteLine("너비는 자연수로 해주세요."); }//value : 매개변수와 같은 기능을 하는 것(키워드)
                else { width = value; }
            
            }
        }

        private int height;

        public int Height //속성
        {
            get { return height; }
            set
            {
                if (value < 0) { Console.WriteLine("높이는 자연수로 해주세요."); }
                else { height = value; }

            }
        }

        public BoxD(int width, int height)
        {
            Height = height;
            Width = width;
            
        }

        public int Area() { return Width * Height; }

        


    }
}
