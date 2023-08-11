using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{  
    public partial class Form1 : Form
    {
        decimal VALOR1 = 0, VALOR2 = 0;
        string OPERACAO = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {            
            txtResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                VALOR1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //CONVERTE CORRETAMENTE A OPERAÇÃO NO VALORE CORRETO, SEM ELE NÃO CONSEGUE FAZER OPERÇÃO COM PONTO.
                txtResultado.Text = "";
                OPERACAO = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            else
            {
                txtResultado.Text = "0";
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                VALOR1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //CONVERTE CORRETAMENTE A OPERAÇÃO NO VALORE CORRETO, SEM ELE NÃO CONSEGUE FAZER OPERÇÃO COM PONTO.
                txtResultado.Text = "";
                OPERACAO = "MULTIPLICACAO";
                lblOperacao.Text = "X";
            }
            else
            {
                txtResultado.Text = "0";
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                VALOR1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //CONVERTE CORRETAMENTE A OPERAÇÃO NO VALORE CORRETO, SEM ELE NÃO CONSEGUE FAZER OPERÇÃO COM PONTO.
                txtResultado.Text = "";
                OPERACAO = "DIVISAO";
                lblOperacao.Text = "/";
            }
            else
            {
                txtResultado.Text = "0";
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                VALOR2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //CONVERTE CORRETAMENTE A OPERAÇÃO NO VALORE CORRETO, SEM ELE NÃO CONSEGUE FAZER OPERÇÃO COM PONTO.

                if (OPERACAO == "SOMA" && txtResultado.Text != "")
                {
                    txtResultado.Text = Convert.ToString(VALOR1 + VALOR2);
                }
                else if (OPERACAO == "SUBTRACAO")
                {
                    txtResultado.Text = Convert.ToString(VALOR1 - VALOR2);
                }
                else if (OPERACAO == "MULTIPLICACAO")
                {
                    txtResultado.Text = Convert.ToString(VALOR1 * VALOR2);
                }
                else if (OPERACAO == "DIVISAO")
                {
                    txtResultado.Text = Convert.ToString(VALOR1 / VALOR2);
                }

            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            txtResultado.Text = "";
            VALOR1 = 0;
            VALOR2 = 0;
            lblOperacao.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                VALOR1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture); //CONVERTE CORRETAMENTE A OPERAÇÃO NO VALORE CORRETO, SEM ELE NÃO CONSEGUE FAZER OPERÇÃO COM PONTO.
                txtResultado.Text = "";
                OPERACAO = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                txtResultado.Text = "0";
            }
           
        }
    }
}
