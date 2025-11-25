using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprogramati48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            operacao = "Adição";
            valor1 = decimal.Parse(txtNum.Text); 
            txtNum.Clear(); 
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            operacao = "Subtração";
            valor1 = decimal.Parse(txtNum.Text);
            txtNum.Clear();
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            operacao = "Multiplicação";
            valor1 = decimal.Parse(txtNum.Text);
            txtNum.Clear();
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            operacao = "Divisão";
            valor1 = decimal.Parse(txtNum.Text);
            txtNum.Clear();
        }

        
        private void Zero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Um_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Ccinco_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtNum.Text); 

            if (operacao == "Adição")
            {
                resultado = valor1 + valor2;
                txtNum.Text = valor1.ToString() + " + " + valor2.ToString();
                txtResul.Text = resultado.ToString();
            }

            if (operacao == "Subtração")
            {
                resultado = valor1 - valor2;
                txtNum.Text = valor1.ToString() + " - " + valor2.ToString();
                txtResul.Text = resultado.ToString();
            }

            if (operacao == "Multiplicação")
            {
                resultado = valor1 * valor2;
                txtNum.Text = valor1.ToString() + " * " + valor2.ToString();
                txtResul.Text = resultado.ToString();
            }

            if (operacao == "Divisão")
            {
                if (valor2 != 0) 
                {
                    resultado = valor1 / valor2;
                    txtNum.Text = valor1.ToString() + " / " + valor2.ToString();
                    txtResul.Text = resultado.ToString();
                }
                else
                {
                    txtResul.Text = "Erro: divisão por zero, por favor, clique em C";
                    txtNum.Clear();
                }
            }
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtResul.Clear();
            valor1 = valor2 = resultado = 0;
            operacao = "";
        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtNum.Text += botao.Text;
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (botao.Text == "+/-")
            {
                if (!string.IsNullOrEmpty(txtNum.Text))
                {
                    decimal valorA = decimal.Parse(txtNum.Text);

                    valorA = valorA * -1;
                    txtNum.Text = valorA.ToString();  

                }

                else
                {
                    txtNum.Text += botao.Text;
                }
            }
        }

        private void Porcentagem_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (operacao == "Multiplicação")
            {
                decimal valorA = decimal.Parse(txtNum.Text);

                valorA /= 100;
                txtNum.Text=valorA.ToString();
            }
            else
            {
                txtNum.Text += botao.Text;
            }
            if (operacao != "Multiplicação")
            {
                txtResul.Text = "Erro: Por favor, use na multiplicação, clique em C";
                txtNum.Clear();
            }
        }
    }
}