using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookA = new Book();

            bookA.Title = "떡볶이 먹고 싶어";
            bookA.Content = "떡볶이는 맛있어유";

            Console.WriteLine("제목: {0}", bookA.Title);
            Console.WriteLine($"내용: {bookA.Content}");

            Console.WriteLine();

            Product product = new Product();

            product.name = "고구마";
            product.price = 5000;
            
            Console.WriteLine($"{product.name} : {product.price} 원");

            Product productA = new Product() { name = "감자", price = 4000 };
            Product productB = new Product() { name = "호박", price = 6000 };
            Product productC = new Product() { name = "당근", price = 3000 };
            Product productD = new Product() { name = "양파", price = 5500 };

            Console.WriteLine(productA.name  + " : " + productA.price +  " 원");
            Console.WriteLine("{0} : {1} 원", productB.name, productB.price);
            Console.WriteLine($"{productC.name} : {productC.price} 원");
            Console.WriteLine($"{productD.name} : {productD.price} 원");

            Console.WriteLine();

            Console.WriteLine("MyMath.PI : " + MyMath.PI);

            Random random = new Random();
            Console.WriteLine(random.Next(1, 100));

            Console.WriteLine(Math.Abs(-150));
            Console.WriteLine();

            Car car = new Car();
            car.Hi();
            car.Go();



        }
    }
}
