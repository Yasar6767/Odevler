using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RecapContext recapContext = new RecapContext();

            //foreach (var car in recapContext.Cars)
            //{
            //    Console.WriteLine(car.CarName);
            //}

            foreach (var personel in recapContext.Personels)
            {
                Console.WriteLine("{0} / {1} / {2}", personel.Id, personel.FirstName, personel.LastName);
            }
        }
    }
}
