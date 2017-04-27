using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

/*
    Project: Assignment 4 - Peasent Simulator 2017
    Class: CP220 - OOP II
    Destription: Multithreading with Form Manipulation
    Name: Michael Dorfman
    Date: 04/27/2017
*/

namespace CP220_ASYNC_P2_UI
{
    public class Peasent
    {
        //Fields
        private string _name;
        private Stopwatch _lifetime = new Stopwatch();
        private int _eventOccurance;
        private ListBox _ListBoxOutput;
        Random RN_OCCUR = new Random();

        //Properties
        public ListBox PLISTBOX
        {
            set
            {
                _ListBoxOutput = value;
            }
        }
        public string name
        {
            get
            {
                return name;
            }
        }

        //Constructor
        public Peasent(string name, ListBox PLISTBOX)
        {
            _name = name;
            _ListBoxOutput = PLISTBOX;
            _ListBoxOutput.Items.Add("Peasent " + _name + " was born.");
            _lifetime.Start();
            _eventOccurance = (int)RN_OCCUR.NextDouble() * (2000 - 500) + 500;
        }

        //Methods
        public async Task LifeTask()
        {
            Form1 containingForm = (Form1)_ListBoxOutput.FindForm();
            while (_lifetime.ElapsedMilliseconds <= 15000)
            {
                Thread.Sleep(_eventOccurance);
                string Event_Output = await Task.Run(() => EventBuilder());
                containingForm.AddItem(_ListBoxOutput, Event_Output);
            }
            containingForm.AddItem(_ListBoxOutput, _name + " died @ " + _lifetime.ElapsedMilliseconds + "ms");
        }

        public string EventBuilder()
        {
            //Constructs Events based on Random Number (Actions the Peasents Do)
            string[] events = new string[5]
            {
                "Working",
                "Protecting",
                "Running",
                "Eating",
                "Sleeping"
            };
            int RN = RN_OCCUR.Next(0, events.Length);
            return events[RN] + " Event: " + _lifetime.ElapsedMilliseconds + " ms";
        }

    }
}
