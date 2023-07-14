using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category {CategoryId=1, CategoryName="Bilgisayar"},
                new Category {CategoryId=2, CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=12000, UnitsInStock=5},
                new Product {ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3},
                new Product {ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=2},
                new Product {ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
                new Product {ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0},
            };

            List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }

            };

            //WhereTest(studentList);
            //JoinTest(categories, products);
            //SingleTest(studentList); -- Sadece bir tanesi şartı uyduğunda çalışır. birden fazla olursa hata verir. Yukarıda yaş 18 olan 2 tane olduğunda single çalışmaz.
            //LastTest(studentList);
            //FirstTest(studentList);
            //GroupByTest(studentList);
            //OftypeTest();
            //AverageTest(products);
            //MinTest(products);
            //MaxTest(products);
            //SumTest(products);
            //GetProducts(products);
            //GetProductsLinq(products);

            //Console.WriteLine("Algoritmik----------------------");
            //foreach (var product in products)
            //{
            //    if (product.UnitPrice>5000 && product.UnitsInStock>3)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }

            //}

            //Console.WriteLine("Linq----------------------");
            //var result = products.Where(p=> p.UnitPrice>5000 && p.UnitsInStock>3);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

        }

        private static void WhereTest(List<Student> studentList)
        {
            var result = studentList.Where(s => s.Age > 18);
            foreach (var student in result)
            {
                Console.WriteLine(student.StudentName);
            }
        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDto { ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };


            foreach (var product in result)
            {
                Console.WriteLine("{0}---{1}---{2}", product.ProductName, product.CategoryName, product.UnitPrice);
            }
        }

        private static void SingleTest(List<Student> studentList)
        {
            var student = studentList.Single(s => s.Age == 20);
            Console.WriteLine(student.StudentName);
        }

        private static void LastTest(List<Student> studentList)
        {
            var student = studentList.Last();
            Console.WriteLine(student.StudentName);
        }

        private static void FirstTest(List<Student> studentList)
        {
            var student = studentList.First();
            Console.WriteLine(student.StudentName);
        }

        private static void GroupByTest(IList<Student> studentList)
        {
            var groupResult = studentList.GroupBy(s => s.Age);

            foreach (var ageGroup in groupResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);

                foreach (Student a in ageGroup)
                    Console.WriteLine("Student Name: {0}", a.StudentName);
            }
        }

        private static void OftypeTest()
        {
            object[] Degerler = { 3.0, null, "beş", 3, "dört", 5, "altı", 7.1 };

            var CiftDuyarliklilar = Degerler.OfType<double>();

            Console.WriteLine("Dizide çift duyarlıklı (double) olarak tutulan değerler :");

            foreach (var Deger in CiftDuyarliklilar)
            {
                Console.WriteLine(Deger);
            }
        }

        private static void AverageTest(List<Product> products)
        {
            var result = products.Average(p => p.UnitPrice);
            Console.WriteLine(result);
        }

        private static void MinTest(List<Product> products)
        {
            var result = products.Min(p => p.UnitPrice);
            Console.WriteLine(result);
        }

        private static void MaxTest(List<Product> products)
        {
            var result = products.Max(p => p.UnitPrice);
            Console.WriteLine(result);
        }

        private static void SumTest(List<Product> products)
        {
            var result = products.Sum(p => p.UnitPrice);
            Console.WriteLine(result);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);
                }
                
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    class ProductDto
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }

        public decimal UnitPrice { get; set; }
    }

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
