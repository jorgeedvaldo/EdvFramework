using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form2 : EdvFramework.EdvForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            edvTextBox1.Text = "hbb";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (edvProgressBar1.Value < 100)
            {
                progressBar1.Value++;
                edvProgressBar1.Value++;
            }
            else {
                timer1.Enabled = false;
                edvProgressBar1.Value = 0;
                progressBar1.Value = 0;
            }
        }

        private void edvButton2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
