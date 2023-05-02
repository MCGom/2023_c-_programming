using System;
using System.Collections.Generic;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //배열: 같은 데이터 타입을 가진 데이터들의 집합(고정)
            int[] alpha = new int[3] { 10, 20, 30 };
            //int[] alpha = new int[] { 10, 20, 30 };
            //int[] alpha = { 10, 20, 30 };

            //alpha[3] = 40;

            foreach (int item in alpha)
            {
                Console.WriteLine(item);
            }

            //리스트: 같은 데이터 타입을 가진 데이터들의 집합(가변)
            List<int> lists = new List<int>(); //리스트는 제네릭해줘야함<>
            lists.Add(10);
            lists.Add(20);
            lists.Add(30);

            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }
            */


            List<int> lists = new List<int>() { 10, 20, 30 };
            lists.Add(40);
            lists.Add(50);
            lists.Add(60);
            lists.Remove(60);
            lists.RemoveAt(0);
            lists.Insert(0, 5);


            foreach (int list in lists)
            {
                Console.WriteLine(list);
            }



        }
    }
}
