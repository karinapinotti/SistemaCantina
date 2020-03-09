using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCantina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void label4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(txtCompra.Text);
            valor2 = Convert.ToInt16(txtRecebido.Text);

            resultado = valor2 - valor1;

            label7.Text = Convert.ToString(resultado);
          
        }
    }
}
