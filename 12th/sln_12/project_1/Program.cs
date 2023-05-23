using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassA obj = new MyClassA();

            obj.my_field = 3;

            Console.WriteLine(obj.my_field);
            Console.WriteLine();

            MyClassB obj2 = new MyClassB();

            obj2.set_my_field(5);
            Console.WriteLine(obj2.get_my_field());
            Console.WriteLine();

            MyClassC obj3 = new MyClassC();
            obj3.My_field = 7;
            Console.WriteLine(obj3.My_field);
            Console.WriteLine();

            MyClassD obj4 = new MyClassD();
            obj4.My_field = 9;
            Console.WriteLine(obj4.My_field);
            Console.WriteLine();

        }
    }
}
