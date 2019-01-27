using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.ForeColor = Color.Black;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.Font = new Font(labelMessageShow.Font.Name, 8);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.Font = new Font(labelMessageShow.Font.Name,16);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.Font = new Font(labelMessageShow.Font.Name, 12);
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.ForeColor = Color.Red;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.ForeColor = Color.Green;
        }

        private void radioButtonMS_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.Text = "Message Show!";
        }

        private void radioButtonHW_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.Text = "Hello World!";
        }

        private void radioButtonFP_CheckedChanged(object sender, EventArgs e)
        {
            labelMessageShow.Text = "First Project!";
        }
    }
}
