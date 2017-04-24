using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            Peasent P2 = new Peasent("Melina", P2_OUTPUT);
            Task NewThread = P1.LifeTask();
            Task NewThread_1 = P2.LifeTask();
            await Task.WhenAll(NewThread, NewThread_1);
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
        }
    }
}
