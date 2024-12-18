using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ResolutiondeProblem
{
    public partial class Equation1 : Form
    {
        public Equation1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out _) && double.TryParse(textBox2.Text, out _))//Cette ligne signifie que s'il n'y a que des chiffres dans la zone de texte, elle fera le travail en dessous.
            {
                float a = float.Parse(textBox1.Text); //Mettre dans la variable textbox1
                float b = float.Parse(textBox2.Text); // Mettre dans la variable textbox2
                MessageBox.Show(" X = " + (-b / a)); // il fera un pop up de la réponse en faisant -b / a
            }
            else //Si on écris les symboles qui ne sont pas les chiffres, elle fera le travail en dessous.
            {
                MessageBox.Show("Les données sont non valides! Refais-le!");// C'est un pop up message
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//Quand ils cliquent sur ce bouton, il n'affichera rien
            textBox2.Text = "";//Quand ils cliquent sur ce bouton, il n'affichera rien
        }
    }
}
