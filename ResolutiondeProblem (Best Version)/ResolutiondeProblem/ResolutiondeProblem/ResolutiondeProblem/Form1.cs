using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ResolutiondeProblem
{
    public partial class Resolutiondeproblem : Form
    {
        public Resolutiondeproblem()
        {
            InitializeComponent();
        }

        private void Resolutiondeproblem_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Equation1 Premier = new Equation1(); //Mettre la forme du premier degré comme variable       
                Premier.ShowDialog(); // Ce code sert à afficher le formulaire si vous cliquez sur la CheckBox.Dialogue est pour le dialogue est de ne pas laisser les gens spammer le formulaire.
                checkBox1.Checked = false; // Ce code est pour retirer la coche
            }



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Equation2 Deuxieme = new Equation2(); //Mettre la forme du deuxieme degré comme variable
                Deuxieme.ShowDialog();// Ce code sert à afficher le formulaire si vous cliquez sur la CheckBox.Dialogue est pour le dialogue est de ne pas laisser les gens spammer le formulaire. 
                checkBox2.Checked = false;// Ce code est pour retirer la coche
            }
           
        }
    }
}
