using System;
using System.Text;
using System.Threading.Tasks;
namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Work(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Works();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Work()
            };

        }
    }

    interface IWorker
    {
        void Works();
        
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

       public void Works()
        {
            throw new NotImplementedException();
        }
    }
    class Work : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Works()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Works()
        {
            throw new NotImplementedException();
        }
    }
}
