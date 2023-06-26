using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            //Demo();
            //InterfacesIntro();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleServerCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Yaşar",
                LastName = "Akat",
                Adress = "Zonguldak"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Elif",
                LastName = "Akat",
                Department = "CEO"
            };

            PersonManager manager = new PersonManager();
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
