﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

/*
    Project: Assignment 4 - Peasent Simulator 2017
    Class: CP220 - OOP II
    Destription: Multithreading Console Application
    Name: Michael Dorfman
    Date: 04/27/2017
*/

namespace CP220_ASYNC_P2
{
    public class Peasent
    {
        //Fields
        private string _name;
        private Stopwatch _lifetime = new Stopwatch();
        private double _eventOccurance;

        //Constructor
        public Peasent(string name)
        {
            _name = name;
            Console.WriteLine("Peasent " + _name + " was born.");
            _lifetime.Start();
            Random RDN = new Random();
            _eventOccurance = RDN.NextDouble() * (2.0 - 0.5) + 0.5;
        }

        //Async Method
        public async Task LifeTask()
        {
            await Task.Run(() =>
            {
                //Event Strings (Actions Peasents Do)
                string[] events = new string[5] { "Working", "Protecting", "Running", "Eating", "Sleeping" };

                Random wEvent = new Random();
                _eventOccurance *= 1000;
                int occurance = (int)_eventOccurance;

                while (_lifetime.ElapsedMilliseconds <= 15000)
                {
                    string event_string = events[wEvent.Next(0, 4)];
                    Thread.Sleep(occurance);
                    Console.WriteLine(_name + " @ " + "Age: " + _lifetime.ElapsedMilliseconds + " Event: " + event_string);
                }
            });
        }
    }
}
