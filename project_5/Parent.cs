﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent()");
        }

        public Parent(int param) { Console.WriteLine("Parent(int param)"); }

        public Parent(string param) { Console.WriteLine("Parent(string param)"); }
    }
}
