using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Project: Assignment 4 - Peasent Simulator 2017
    Class: CP220 - OOP II
    Destription: Multithreading with Form Manipulation
    Name: Michael Dorfman
    Date: 04/27/2017
*/

namespace CP220_ASYNC_P2_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSimStatus.Text = "INACTIVE";
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            //Modifies Control Settings For UI
            btnStart.Enabled = false;
            btnStart.BackColor = Color.Red;
            btnStart.Text = "START SIMULATION (DISABLED)";
            txtSimStatus.BackColor = Color.LimeGreen;
            txtSimStatus.Text = "ACTIVE";

            //Creates Peasent Objects
            Peasent P1 = new Peasent("Mikhail", P1_OUTPUT);
            Thread.Sleep(15);
            Peasent P2 = new Peasent("Melina", P2_OUTPUT);

            //Creats & Runs Thread Tasks
            Task NX1 = Task.Run(P1.LifeTask);
            Task NX2 = Task.Run(P2.LifeTask);

            //Waits for Threads to Exit
            await Task.WhenAll(NX1, NX2);

            //Modifies Form Controls After Threads Exit
            txtSimStatus.Text = "INACTIVE";
            txtSimStatus.BackColor = Color.LimeGreen;
            btnStart.Text = "START SIMULATION";
            btnStart.Enabled = true;
            btnStart.BackColor = Color.LimeGreen;
        }
        //Invoke Method needed to modify form from other threads (Cross Threading)
        public void AddItem(ListBox lbox, string str)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<ListBox, string>(AddItem), new object[] { lbox, str });
                return;
            }
            lbox.Items.Add(str);
            lbox.SelectedIndex = lbox.Items.Count - 1;
        }
    }
}
