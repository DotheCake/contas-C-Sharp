using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modulo_de_divisão
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int resto = dividendo % divisor;
            txtRestoDaDivisao.Text = resto.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int somaNumero1 = Convert.ToInt32(txtSoma1.Text);
            int somaNumero2 = Convert.ToInt32(txtSoma2.Text);
            int resultadoSoma = somaNumero1 + somaNumero2;
            txtResultadoDaSoma.Text = resultadoSoma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int subNumero1 = Convert.ToInt32(txtSub1.Text);
            int subNumero2 = Convert.ToInt32(txtSub2.Text);
            int resultadoSub = subNumero1 - subNumero2;
            txtResultadoSub.Text = resultadoSub.ToString();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int multiNumero1 = Convert.ToInt32(txtMulti1.Text);
            int multiNumero2 = Convert.ToInt32(txtMulti2.Text);
            int resultadoMulti = multiNumero1 * multiNumero2;
            txtResultadoDaMulti.Text = resultadoMulti.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int somaTresNumero1 = Convert.ToInt32(txtSomaTres1.Text);
            int somaTresNumero2 = Convert.ToInt32(txtSomaTres2.Text);
            int somaTresNumero3 = Convert.ToInt32(txtSomaTres3.Text);
            int resultadoSomaTres = somaTresNumero1 + somaTresNumero2 + somaTresNumero3;
            txtResultadoSomaTres.Text = resultadoSomaTres.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);
            int numero3 = Convert.ToInt32(txtNumero3.Text);
            int numero4 = Convert.ToInt32(txtNumero4.Text);
            int numero5 = Convert.ToInt32(txtNumero5.Text);
            int resultadoConta = (numero1 + numero2);
        }
    }
}
