using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolutiondeProblem
{
    public partial class Equation2 : Form
    {
        public Equation2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out _) && double.TryParse(textBox2.Text, out _) && double.TryParse(textBox3.Text, out _))
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);
                float d = (b * b) - 4 * a * c;
                if (d < 0)
                {
                    MessageBox.Show("Indéfini!\nAucune Solution.");
                }
                else if (d == 0)
                {
                    MessageBox.Show("X1 = " + (-b / (2 * a)));
                }
                else if (d > 0)
                {
                    MessageBox.Show("X1 = " + (-b + Math.Sqrt(d)) / (2 * a) + "\nX2 = " + (-b - Math.Sqrt(d)) / (2 * a));
                }
            }
            else
            {
                MessageBox.Show("Les données sont non valides! Refais-le!");
            }


          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}

