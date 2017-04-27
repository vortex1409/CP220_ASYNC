using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Project: Assignment 4 - Peasent Simulator 2017
    Class: CP220 - OOP II
    Destription: Multithreading Console Application
    Name: Michael Dorfman
    Date: 04/27/2017
*/

namespace CP220_ASYNC_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Application
            Console.WriteLine("Peasent Simulator 2017");
            Console.WriteLine("Press Any Key");
            Console.ReadKey();

            //Begins Simulation
            StartAsync();
            Console.ReadKey();
        }

        public static async void StartAsync()
        {
            await Task.Run(() =>
            {
                //Creates Objects and Starts Thread Tasks
                Peasent P1 = new Peasent("Mikhail");
                Task NewThread = P1.LifeTask();
                Peasent P2 = new Peasent("Melina");
                Task NewThread_1 = P2.LifeTask();
            });
        }
    }
}
