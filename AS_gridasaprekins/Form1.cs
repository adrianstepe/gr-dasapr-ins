using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            double telpaG = Convert.ToDouble(telpasg.Text);
            double telpaP = Convert.ToDouble(telpasp.Text);
            double laukums1 = telpaG * telpaP;
            textBox5.Text = Convert.ToString(laukums1 + comboBox1.Text + "²");
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

        private void button3_Click(object sender, EventArgs e)
        {
            string nosaukums = textBox1.Text.ToString();
            string teksts = textBox6.Text.ToString();
            string teksts1 = textBox5.Text.ToString();

            if (File.Exists(nosaukums + ".txt"))
            {
                using (StreamWriter sw = File.AppendText(nosaukums + ".txt"))
                {
                    sw.WriteLine(teksts);
                    sw.WriteLine(teksts1);
                    MessageBox.Show("Fails papildināts!");
                }

            }
            else
            {
                File.WriteAllText(nosaukums + ".txt", teksts + teksts1 );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nosaukums = textBox1.Text.ToString();

            if (File.Exists(nosaukums + ".txt"))
            {
                string readText = File.ReadAllText(nosaukums + ".txt");
                richTextBox1.Text = readText;
            }
            else
            {
                MessageBox.Show("Fails nav atrasts!");
            }
        }
    }
}
