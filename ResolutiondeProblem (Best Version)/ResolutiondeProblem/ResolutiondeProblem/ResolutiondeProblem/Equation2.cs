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
            if (double.TryParse(textBox1.Text, out _) && double.TryParse(textBox2.Text, out _) && double.TryParse(textBox3.Text, out _)) //Cette ligne vérifie si les données sont valides
            {
                double a = double.Parse(textBox1.Text);//Mettre dans la variable textbox1
                double b = double.Parse(textBox2.Text);//Mettre dans la variable textbox2
                double c = double.Parse(textBox3.Text);//Mettre dans la variable textbox3
                double d = (b * b) - 4 * a * c;//Mettre an variable la formule de delta
                if (d < 0)//Si delta est negative
                {
                    MessageBox.Show("Indéfini!\nAucune Solution");//Sa fait un Pop up
                }
                else if (d == 0)//Si delta est 0
                {
                    textBox4.Text = "X1 = " +((-b / (2 * a))).ToString();// fait la calculation de X1
                    textBox6.Text = "Aucune";//Montre qù'il a aucune réponse
                    textBox4.Visible = true;// rend visible la réponse
                    textBox6.Visible = true;//rend visible la réponse
                }
                else if (d > 0)//Si delta est positive
                {
                    textBox4.Text = "X1 = " + ((-b + Math.Sqrt(d)) / (2 * a)).ToString(); // fait la calculation de X1
                    textBox6.Text = "X2 = " + ((-b - Math.Sqrt(d)) / (2 * a)).ToString();// fait la calculation de X2
                    textBox4.Visible = true;// rend visible la réponse
                    textBox6.Visible = true;//rend visible la réponse
                }
              

            }
            else// //Si on écris les symboles qui ne sont pas les chiffres, elle fera le travail en dessous.
            {
                MessageBox.Show("Les données sont non valides! Refais-le!");//Sa fait un Pop up
            }                 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

