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
            _ListBoxOutput.Items.Add("Peasent " + _name + "was born.");
            _lifetime.Start();
            _eventOccurance = (int)RN_OCCUR.NextDouble() * (2000 - 500) + 500;
        }

        //Methods
        public async Task LifeTask()
        {
            Form1 containingForm = (Form1)_ListBoxOutput.FindForm();
            await Task.Run(() =>
            {
                string[] events = new string[5] { "Working", "Protecting", "Running", "Eating", "Sleeping" };
                Random wEvent = new Random();
                _eventOccurance *= 1000;
                int occurance = (int)_eventOccurance;
                while (_lifetime.ElapsedMilliseconds <= 5000)
                {
                    string event_string = events[wEvent.Next(0, 4)];
                    Thread.Sleep(occurance);
                    Console.WriteLine(_name + " @ " + "Age: " + _lifetime.ElapsedMilliseconds + " Event: " + event_string);
                }
                containingForm.AddItem(_ListBoxOutput, _name + " is dead " + " @ " + _lifetime.ElapsedMilliseconds + " ms");
            });
        }

    }
}
