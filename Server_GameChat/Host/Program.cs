using System;
using System.ServiceModel;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(WCF.Service));
            var host2 = new ServiceHost(typeof(WCF.Service2));
            host.Open();
            Console.WriteLine("Хост запущен1");
            host2.Open();
            Console.WriteLine("Хост запущен2");
            Console.ReadLine();
        }
    }
}
