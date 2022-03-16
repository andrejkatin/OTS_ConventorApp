using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RbtnMass_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            label1.Text = "pounds";
            label2.Text = "kg";
        }

        private void RbtnLength_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "feet";
            label2.Text = "m";
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (rbtnMass.Checked)
            {
                MassConventer conventer = new MassConventer();
                textBox2.Text = conventer.Convert(Double.Parse(textBox1.Text)).ToString();
            }
            else if (rbtnLength.Checked)
            {
                LengthConventer conventer = new LengthConventer();
                textBox2.Text = conventer.Convert(Double.Parse(textBox1.Text)).ToString();
            }
            else
            {
                MessageBox.Show("You have to select conversion type!");
            }
        }
    }
}
