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
    delegate double clacularDobles(double numero);

    public partial class Delegados1 : Form
    {

        Calculador calculador;

        public Delegados1()
        {
            InitializeComponent();
            calculador = new Calculador(5.7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clacularDobles delegado = calculador.multiplicar;
            double valor = Convert.ToDouble(textBox1.Text);
            var result = delegado(valor);
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clacularDobles delegado = calculador.sumar;
            Double valor = Double.Parse(textBox1.Text);
            var result = delegado(valor);
            label1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar que la tecla presionada no sea CTRL u otra tecla no numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Para permitir permitir numeros decimales (o float)
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
