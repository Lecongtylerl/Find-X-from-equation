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
                Equation1 newForm = new Equation1();
                newForm.ShowDialog();
                checkBox1.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Equation2 newForm = new Equation2();
                newForm.ShowDialog();
                checkBox2.Checked = false;
            }
        }
    }
}
