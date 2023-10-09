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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.ShowDialog();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            objForm2.ShowDialog();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            Form3 objForm3 = new Form3();
            objForm3.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            Form4 objForm4 = new Form4();
            objForm4.ShowDialog();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            Form5 objForm5 = new Form5();
            objForm5.ShowDialog();
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            Form6 objForm6 = new Form6();
            objForm6.ShowDialog();
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.ShowDialog();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            Form8 objForm8 = new Form8();
            objForm8.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 objForm9 = new Form9();  
            objForm9.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 objForm10 = new Form10();   
            objForm10.ShowDialog();
        }
    }
}
