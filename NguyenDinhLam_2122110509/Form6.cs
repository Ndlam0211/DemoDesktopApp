using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDinhLam_2122110509
{
    public partial class Form6 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = " ";
        public Form6()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);
                if (opr == "+")
                    txtDisplay.Text = (workingMemory + secondValue).ToString();
                if (opr == "*")
                    txtDisplay.Text = (workingMemory * secondValue).ToString();
                if (opr == "-")
                    txtDisplay.Text = (workingMemory - secondValue).ToString();
                if (opr == "/")
                    txtDisplay.Text = (workingMemory / secondValue).ToString();
            }
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = 1 / currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "M+")
            {
                memory = memory + decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-")
            {
                memory = memory - decimal.Parse(txtDisplay.Text);

            }
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {

            }
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt9.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt4.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt5.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt6.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt3.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt0.Text;
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btDot.Text;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
