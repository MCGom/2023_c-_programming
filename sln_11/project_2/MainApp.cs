using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    class MainApp
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Calling Int Plus(int, int)");
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling Int Plus(int, int, int)");
            return a + b + c; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
        }

        public static double Plus(double a, double b)
        {
            Console.WriteLine("Calling Double Plus(double, double)");
            return a + b;
        }

        public static double Plus(double a, double b, double c)
        {
            Console.WriteLine("Calling Double Plus(double, double, double)");
            return a + b + c;
        }
    }
}
