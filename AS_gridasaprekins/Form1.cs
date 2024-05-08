using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_gridasaprekins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double telpaG = Convert.ToDouble(telpasg.Text);
            double telpaP = Convert.ToDouble(telpasp.Text);
            double laukums1 = telpaG * telpaP;
            textBox5.Text = Convert.ToString(laukums1 + comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double telpaG = Convert.ToDouble(telpasg.Text);
            double telpaP = Convert.ToDouble(telpasp.Text);
            double laukums1 = telpaG * telpaP;
            double Mcena = Convert.ToDouble(textBox3.Text);
            double izmaksas = laukums1 * Mcena;
            textBox6.Text = Convert.ToString(izmaksas + "€");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
