using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arduino.Connect();
        }

        private void serialArduino_Load(object sender, EventArgs e)
        {

        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            arduino.SetReg(0, 0);
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            arduino.SetReg(0, 1);
        }
    }
}
