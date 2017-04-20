using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP220_ASYNC_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peasent Simulator 2017");
            Console.WriteLine("Press Any Key");
            Console.ReadKey();
            StartAsync();
            Console.ReadKey();
        }

        public static async void StartAsync()
        {
            await Task.Run(() =>
            {
                Peasent P1 = new Peasent("Mikhail");
                Task NewThread = P1.LifeTask();
                Peasent P2 = new Peasent("Melina");
                Task NewThread_1 = P2.LifeTask();
            });
        }
    }
}
