using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var tip = typeof(DortIslem);
            //DortIslem dortİslem = (DortIslem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortİslem.Topla(4, 5));
            //Console.WriteLine(dortİslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 9);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("----------------------------------");

            var metodlar = tip.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod Adı : " + info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute : {0}",attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }

        class DortIslem
        {
            private int _sayi1;
            private int _sayi2;
            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }
            public DortIslem()
            {

            }
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;            
            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }

            [MethodName("carpma")]
            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }
        }

        public class MethodNameAttribute : Attribute
        {
            public MethodNameAttribute(string name)
            {

            }
        }
    }
}
