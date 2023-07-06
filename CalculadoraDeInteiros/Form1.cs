using System;

namespace CalculadoraDeInteiros
{
    public partial class Form1 : Form
    {
        public int resultado, numtemp;
        public string operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numtemp = (numtemp * 10) + num;
        }
        private void digiteOperacao(string operador)
        {
            resultado = numtemp;
            numtemp = 0;
            operacao = operador;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DigitaNumero(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DigitaNumero(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DigitaNumero(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DigitaNumero(8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DigitaNumero(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            numtemp = (numtemp * 10) + num;

        }

        private void btm_resultado_Click(object sender, EventArgs e)
        {
            switch (numtemp)
            {
                case '+':

            }
        }

        private void btm_soma_Click(object sender, EventArgs e)
        {
            digiteOperacao("+");
        }

        private void btm_menos_Click(object sender, EventArgs e)
        {
            digiteOperacao("-");
        }

        private void btm_divisao_Click(object sender, EventArgs e)
        {
            digiteOperacao("/");
        }

        private void btm_multi_Click(object sender, EventArgs e)
        {
            digiteOperacao("*");
        }
    }
}