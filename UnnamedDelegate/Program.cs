using System;
using System.Collections.Generic;

namespace UnnamedDelegate
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static void Main(string[] args)
        {
            //List를 생성
            List<Product> products = new List<Product>()
            {
                new Product() {Name = "감 자", Price = 5000},
                new Product() {Name = "사 과", Price = 7000},
                new Product() {Name = "고구마", Price = 4000},
                new Product() {Name = "배 추", Price = 6000},
                new Product() {Name = "상 추", Price = 3000}
            };

            //무명 델리게이트로 정렬 방법 정의
            /*products.Sort(
                delegate (Product a, Product b)
                {
                    return a.Price.CompareTo(b.Price);
                }
                );*/

            // Sort() 메서드의 매개 변수로 람다를 지정
            products.Sort((a, b) => a.Price.CompareTo(b.Price));

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }
    }
}
