using System;

namespace project_1
{
    class Book
    {
        public string title;    //변수(필드)
        public string content;
        public string writer;
        public string publisher;
        public int published_date;

        public void print_Book()
        {
            Console.WriteLine("제목 : " + title);
            Console.WriteLine("내용 : " + content);
            Console.WriteLine("저자 : " + writer);
            Console.WriteLine("출판사 : " + publisher);
            Console.WriteLine("출판일 : " + published_date);
        }

        public Book()
        {
        }

        public Book(string title, string content, string writer, string publisher, int published_date)
        {
            this.title = title;
            this.content = content;
            this.writer = writer;
            this.publisher = publisher;
            this.published_date = published_date;
        }
    }

    class Product
    {
        public string name;
        public int price;

    }

    class Program
    {
        static void Main(string[] args)
        {
            //다음 중 클래스를 정의할 수 없는 곳
            //메인에는 위치할 수 없다.(단, 사용은 가능)

            Book book = new Book();
            //Book 설계도로부터 book (객체, 인스턴스)를 생성

            book.title = "C# 프로그래밍";
            book.content = "열심히 실습합시다.";
            book.writer = "김민철";
            book.publisher = "도서 출판 유한";
            book.published_date = 20230502;

            Console.WriteLine("제목 : " + book.title + " (문자열 연결 연산자)");
            Console.WriteLine("제목 : {0} (스트링 포멧)", book.title);
            Console.WriteLine($"제목 : {book.title} (보간법)");

            Console.WriteLine();

            book.print_Book();

            Console.WriteLine();

            Book new_book = new Book("어린 왕자", "어린 왕자의 모험", "누군가", "어떤 출판사", 20000101);

            new_book.print_Book();

            Console.WriteLine();

            Product product1 = new Product();

            product1.name = "감자";
            product1.price = 4000;

            Console.WriteLine(product1.name + " : " + product1.price + "원");
            Console.WriteLine("{0} : {1}원", product1.name, product1.price);
            Console.WriteLine($"{product1.name} : {product1.price}원");

            Console.WriteLine();

            Product product2 = new Product() { name = "고구마", price = 5000 };

            Console.WriteLine($"{product2.name} : {product2.price}원");

            Console.WriteLine();

            Product product3 = new Product() { name = "호박", price = 10000 };

            Console.WriteLine($"{product3.name} : {product3.price}원");

            Console.WriteLine();


        }
    }
}
