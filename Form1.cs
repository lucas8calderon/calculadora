﻿using System;
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

        decimal valor1 = 0, valor2 = 0;


        string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {


            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

        


            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);


            if (operacao == "SOMA")

              txtResultado.Text = Convert.ToString (valor1 + valor2);




        }

        private void button7_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";


        }

        private void button12_Click(object sender, EventArgs e)
        {


            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "x";


        }

        private void button17_Click(object sender, EventArgs e)
        {

            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";


        }
    }
}
