using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMarketManager sarkuteri = new Sarkuteri();
            //IMarketManager kasap = new Kasap();
            //IMarketManager manav = new Manav();
            IMarketManager[] marketManagers = new IMarketManager[3]
            {
                new Kasap(),
                new Sarkuteri(),
                new Manav()
            };

            foreach (var marketManager in marketManagers)
            {
                marketManager.Add();
                marketManager.Update();
            }


        }
    }

    interface IMarketManager
    {
        void Add();
        void Update();
        void Delete();
    }

    class Sarkuteri : IMarketManager
    {
        public void Add()
        {
            Console.WriteLine("Şarküteri ürünleri eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Şarküteri ürünleri silindi");
        }

        public void Update()
        {
            Console.WriteLine("Şarküteri ürünleri güncellendi");
        }
    }

    class Kasap : IMarketManager
    {
        public void Add()
        {
            Console.WriteLine("Kasap ürünleri eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kasap ürünleri silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kasap ürünleri güncellendi");
        }
    }

    class Manav : IMarketManager
    {
        public void Add()
        {
            Console.WriteLine("Manav ürünleri eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Manav ürünleri silindi");
        }

        public void Update()
        {
            Console.WriteLine("Manav ürünleri güncellendi");
        }
    }

    class GrossManager
    {
        public void Add(IMarketManager marketManager)
        {
            marketManager.Add();
        }
    }
}
