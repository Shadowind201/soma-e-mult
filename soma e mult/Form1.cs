using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soma_e_mult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(num1.Text);
            int valor2 = Convert.ToInt32(num2.Text);
            int valor3 = Convert.ToInt32(num3.Text);
            int valor4 = Convert.ToInt32(num4.Text);

            double soma = (valor1 + valor2 + valor3 + valor4);
            lblSoma.Text = "Soma é: " + soma.ToString();

            double mult = (valor1 * valor2 * valor3 * valor4);
            lblMult.Text = "Multiplicação é: " + mult.ToString();
        }
    }
}
