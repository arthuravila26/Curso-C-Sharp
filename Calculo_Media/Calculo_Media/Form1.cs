using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, media;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            media = (num1 + num2) / 2;
            txtMedia.Text = media.ToString();
            if (media < 5)
                MessageBox.Show("Você foi reprovado!", "Reprovado");
            else if (media >= 7)
                MessageBox.Show("Parabéns, você foi aprovado!", "Aprovado");
            else
                MessageBox.Show("Você esta de recuperação.", "Recuperação");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtMedia.Text = "";
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
