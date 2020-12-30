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
        String error = "Your parenthesis are not equal";
        double sum = 0;
        Regex r;
        bool negNum = false;
        int paranNum =  0;
        int negSpot;

        public Form1()
        {
            InitializeComponent();
            string pattern = "[0-9.]";
            r = new Regex(pattern);
        }

        private void CalcBody_Load(object sender, EventArgs e)
        {

        }

        private void  clear_Click(object sender, EventArgs e)
        {
            equation = "";  
            eqaBox.Text = "";
            eqaBox.Text = equation;
            negNum = false;
        }

        private void parans_Click(object sender, EventArgs e)
        {
            eqaBox.Text = "";
            equation += "(";
            paranNum += 1;
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
            InsertRemoveNeg();
        }

        private void EndParan_Click(object sender, EventArgs e)
        {
            equation += ")";
            paranNum -= 1;
            eqaBox.Text = "";
            eqaBox.Text += equation;
            negNum = false;
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
            if (paranNum != 0)
            {
                MessageBox.Show(error);
            }
            else
            {
                Parsing sent = new Parsing();
                sum = sent.ReadString(equation, r, 0);
                equation = sum.ToString();
                eqaBox.Text = "";
                eqaBox.Text = equation;
                negNum = false;
            }
        }

        private void erase_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation.Remove((equation.Length - 1));
                eqaBox.Clear();
                eqaBox.Text = equation;
            }
        }

        private void Power_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InsertRemoveNeg()
        {

            int spot = equation.Length;           
            if (negNum == true)
            {
                
                equation = equation.Remove(negSpot, 2);
                //MessageBox.Show($"here {equation.Length}"); for trouble shooting
                eqaBox.Text = equation;
                negNum = false;
                spot = negSpot;
                paranNum -= 1;
                negSpot = 0;

            }
            else if ( spot == 0)
            {
                equation = equation.Insert(negSpot, "(-");
                eqaBox.Text = equation;
                negNum = true;
                negSpot = spot;
                paranNum += 1;
            }
            else
            {
                for (int x = spot - 1; x >= 0; x--)
                {
                    if ( x == 0 || !(r.IsMatch(equation[x].ToString())))
                    {                       
                        equation = x == 0 ? equation.Insert(x, "(-") : equation.Insert(x + 1, "(-");
                        negSpot = x== 0 ? x : x + 1;
                        negNum = true;
                        paranNum += 1;
                        eqaBox.Clear();
                        eqaBox.Text = equation;
                        break;
                    }
                }
            }
    
        }

       
    }
}
