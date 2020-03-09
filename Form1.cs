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
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;

        public Form1()
        {
            InitializeComponent();
        }
        private void label3_TextChanged(object sender, EventArgs e)
        {
        }
        public void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encntrado");
                }
                else
                {
                    lstCaixa.Items.Add(txtCodigo.Text + " -- " + produtos[indice] + "-- R$" + valor[indice]);
                    soma = soma + valor[indice];
                    label3.Text = ("Valor Total R$ " + soma);
                    picImagem.ImageLocation = "c:/imagens/" + codigo[indice] + ".jpeg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }

        private void carregarArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";
            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot_Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";
            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;
}
        private void picImagem_Click(object sender, EventArgs e)
        {
        }
        private void lstCaixa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Form2 FormPagar = new Form2();
            FormPagar.ShowDialog();
        }

        private void btnPagar_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
