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

    public partial class Lambda : Form
    {
        public Lambda()
        {
            InitializeComponent();
        }

        private void Lambda_Load(object sender, EventArgs e)
        {
            
        }

        private void operacion(clacularDobles delegado, double numa, double numb, string titulo)
        {
            var result = delegado(numa) + numb;
            label1.Text = titulo + ":" + Convert.ToString(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion((x) => { return x + 67; }, 67.4, 3.14, "Suma");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion((x) => { return x * 67; }, 67.4, 3.14, "Multiplicar");
        }
    }
}
