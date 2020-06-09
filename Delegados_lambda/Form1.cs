using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados_lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void primerEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delegados1 del = new Delegados1();
            del.MdiParent = this;
            del.Show();
        }

        private void segundoEjemploToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lambda lam = new Lambda();
            lam.MdiParent = this;
            lam.Show();
        }

        private void linQsimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinQsimpleForm form = new LinQsimpleForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
