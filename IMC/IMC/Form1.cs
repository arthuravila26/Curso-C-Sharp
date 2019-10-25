using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, resultado;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            resultado = peso / (altura * altura);

            if (resultado < 18.5)
                MessageBox.Show("Você está abaixo do seu peso ideal.", "Mensagem");
            if (resultado >= 18.5 && resultado <= 24.9)
                MessageBox.Show("Você está no seu peso ideal.", "Mensagem");
            if (resultado >= 25 && resultado <= 29.9)
                MessageBox.Show("Você está acima do seu peso ideal", "Mensagem");
            if (resultado >= 30 && resultado <= 34.9)
                MessageBox.Show("Você está com obesidade grau 1", "Mensagem");
            if (resultado >= 35 && resultado <=39.9)
                MessageBox.Show("Você está com obesidade grau 2", "Mensagem");
            if (resultado > 40)
                MessageBox.Show("Você está com obesidade grau 3", "Mensagem");

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
