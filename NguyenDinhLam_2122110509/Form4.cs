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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        float data1,data2;
        string calculation;

        private void btn0_Click(object sender, EventArgs e)
        {
            view.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + "3";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calculation = "plus"; 
            data1 = float.Parse(view.Text);
            view.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e) 
        {
            if (calculation == "plus")
            {
                data2 = data1 + float.Parse(view.Text);
                view.Text = data2.ToString();
            }

            if (calculation == "multi")
            {
                data2 = data1 * float.Parse(view.Text);
                view.Text = data2.ToString();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            calculation = "multi";
            data1 = float.Parse(view.Text);
            view.Clear(); 
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            view.Text = view.Text + ".";
        }
    }
}
 
