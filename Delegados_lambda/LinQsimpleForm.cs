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
    public partial class LinQsimpleForm : Form
    {
        
        CalculadoQ calQ;

        public LinQsimpleForm()
        {
            InitializeComponent();
        }

        private void LinQsimpleForm_Load(object sender, EventArgs e)
        {
            var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            calQ = new CalculadoQ(valores);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sum = calQ.suma();
            label1.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> lista = calQ.pares();
            listBox1.DataSource = lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sum = calQ.sumaQ();
            label2.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lista = calQ.paesQ();
            listBox2.DataSource = lista;
        }
    }
}
