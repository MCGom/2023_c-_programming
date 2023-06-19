using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static int SortWithPrice(Product a, Product b)
        {
            return a.Price.CompareTo(b.Price);
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

            //정렬
            products.Sort(SortWithPrice);

            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }
    }
}
