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

namespace CP220_ASYNC_P2_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            txtSimStatus.Text = "Simulation In Progress";
            Peasent P1 = new Peasent("Mikhail", P1_OUTPUT);
            Thread.Sleep(10);
            Peasent P2 = new Peasent("Melina", P2_OUTPUT);

            Task NX1 = Task.Run(P1.LifeTask);
            Task NX2 = Task.Run(P2.LifeTask);

            await Task.WhenAll(NX1, NX2);

            txtSimStatus.Text = "Simulation Ended";
        }
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
