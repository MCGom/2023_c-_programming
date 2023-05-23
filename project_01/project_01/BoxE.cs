using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_01
{
    class BoxE 
    {
        private int width; //변수

        public int Width //속성
        {
            get;
            set;
        }

        private int height;

        public int Height //속성
        {
            get;
            set;
        }

        public BoxE(int width, int height)
        {
            Height = height;
            Width = width;
            
        }

        public int Area() { return Width * Height; }

        


    }
}
