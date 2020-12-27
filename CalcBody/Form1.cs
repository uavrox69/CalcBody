using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace CalcBody
{
    public partial class Form1 : Form
    {
        String equation = "";
        double sum = 0;
        Regex r;

        public Form1()
        {
            InitializeComponent();
            string pattern = "[0-9.]";
            r = new Regex(pattern);
        }

        private void CalcBody_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            eqaBox.Text = "";
            eqaBox.Text = equation;
        }

        private void parans_Click(object sender, EventArgs e)
        {
            eqaBox.Text = "";
            equation += "(";
            eqaBox.Text = equation;
        }

        private void one_Click(object sender, EventArgs e)
        {
            equation += "1";
            eqaBox.Text = "";
            eqaBox.Text = equation;
        }

        private void two_Click(object sender, EventArgs e)
        {
            equation += "2";
            eqaBox.Text = "";
            eqaBox.Text = equation;
        }

        private void three_Click(object sender, EventArgs e)
        {
            equation += "3";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void four_Click(object sender, EventArgs e)
        {
            equation += "4";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void five_Click(object sender, EventArgs e)
        {
            equation += "5";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void six_Click(object sender, EventArgs e)
        {
            equation += "6";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            equation += "7";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            equation += "8";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            equation += "9";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            equation += "0";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void deci_Click(object sender, EventArgs e)
        {
            equation += ".";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void posNeg_Click(object sender, EventArgs e)
        {

        }

        private void EndParan_Click(object sender, EventArgs e)
        {
            equation += ")";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            equation += "/";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            equation += "*";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            equation += "-";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            equation += "+";
            eqaBox.Text = "";
            eqaBox.Text += equation;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            Calculator.Parsing sent = new Calculator.Parsing();
           
            sum = sent.ReadString(equation, r, 0);           
            eqaBox.Text = "";
            eqaBox.Text = sum.ToString();
        }
    }
}
