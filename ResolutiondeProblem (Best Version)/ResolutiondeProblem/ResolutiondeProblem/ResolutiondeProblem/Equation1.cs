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
                double a = double.Parse(textBox1.Text); //Mettre dans la variable textbox1
                double b = double.Parse(textBox2.Text); // Mettre dans la variable textbox2
                textBox4.Text = (" X = " + (-b / a)); // il fera la réponse en faisant -b / a, et le montre au textbox4   
                textBox4.Visible = true;              
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
            textBox4.Text = "";//Quand ils cliquent sur ce bouton, il n'affichera rien
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            float b = float.Parse(a);
            if ( b > 999999)
            {
                MessageBox.Show("Ils ont plus de 6 chiffres dans la zone de texte. Veuillez supprimer les numéros de somme jusqu'à ce que vous atteigniez l'exigence!");
                textBox1.Text = "";
            }
        }
    }
}
