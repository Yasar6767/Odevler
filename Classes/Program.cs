using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.City = "Zonguldak";
            customer1.FirstName = "Yaşar";
            customer1.LastName = "Akat";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Trabzon", FirstName = "Elif", LastName = "Akat"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
