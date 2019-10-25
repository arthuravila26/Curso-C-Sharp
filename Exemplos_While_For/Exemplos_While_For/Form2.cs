using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplos_While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2019;

            while (contador >= 1950)
            {
                cboAno.Items.Add(contador);
                contador--;
            }
            /*Declaração da variável contador do tipo inteiro, onde foi atribuído o valor de 2016(ano),
             * Enquanto o contador for maior ou igual a 1950, o contador faz o decremento.
             * Ou seja, começa com 2016 e vai até 1950
             * Itens são adicionador no Contador.*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }
    }
}
