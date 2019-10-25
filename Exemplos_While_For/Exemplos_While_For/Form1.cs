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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2019; contador >= 1950; contador--)
            {
                cboAno.Items.Add(contador);
            }
            /*Declaração da variável contador do tipo inteiro
             * Laço For - Atribuído o valor de 2019(ano), até que o ano seja maior ou igual a 1950, o contador vai fazendo um decremento.
             * Ou seja começa com 2019 e vai até 1950.
             * Em seguida os itens são adicionados no Contador.
             * */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}
