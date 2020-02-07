using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Display.Text += '1';
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Display.Text += '2';
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Display.Text += '3';
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Display.Text += '4';
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Display.Text += '5';
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Display.Text += '6';
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Display.Text += '7';
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Display.Text += '8';
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Display.Text += '9';
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Display.Text += '0';
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            Display.Text += '%';
        }

        private void Btn1Div_Click(object sender, EventArgs e)
        {
            Display.Text += "1/";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Display.Text = new DataTable().Compute(Display.Text, null).ToString();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Display.Text += '+';
        }

        private void BtnComa_Click(object sender, EventArgs e)
        {
            Display.Text += ',';
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            Display.Text += '√';
        }

        private void BtnMM_Click(object sender, EventArgs e)
        {
            Display.Text += '±';
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length - 1);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Display.Text += '/';
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            Display.Text += '*';
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Display.Text += '-';
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
