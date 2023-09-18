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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtx.Text);
            double y = Convert.ToDouble(txty.Text);
            double kq = x + y;
            txtkq.Text = kq.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtx.Text);
            double y = Convert.ToDouble(txty.Text);
            double kq = x * y;
            txtkq.Text = kq.ToString();
        }
    }
}
