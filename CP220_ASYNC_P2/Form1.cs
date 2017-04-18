using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CP220_ASYNC_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    public class peasant
    {
        //Fields
        private string _name;
        private Stopwatch _lifetime;
        private double _eventOccurance;
        private string _lbox_data;

        //Properties
        public string lbox_data
        {
            get { return _lbox_data; }
            set { _lbox_data = lbox_data; }
        }
       
    }
}
