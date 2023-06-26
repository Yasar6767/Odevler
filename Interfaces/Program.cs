using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonelManager customerManager = new CustomerManager();
            //customerManager.Add();

            IPersonelManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            
            

            PersonManager personManager = new PersonManager();
            personManager.Add(customerManager);
            personManager.Add(new InternManager());
        }
    }

    interface IPersonelManager
    {
        //Implemented operation(Tamamlanmış operasyon)
        void Add();
        void Update();
    }

    //inherits - class ------------------- implements - interface
    class CustomerManager : IPersonelManager
    {
        //Müşteri ekleme kodları
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonelManager
    {
        //Personel ekleme kodları
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonelManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class PersonManager
    {
        public void Add(IPersonelManager personelManager)
        {
            personelManager.Add();
        }
    }
}
