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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        void Form9_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            richTextBox1.Text = item.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
