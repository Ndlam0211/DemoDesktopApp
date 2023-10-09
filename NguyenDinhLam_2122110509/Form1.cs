using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NguyenDinhLam_2122110509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool CheckData()
        {
            String strUserName = txtUserName.Text;
            String strPassword = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(strUserName))
            {
                MessageBox.Show("You haven't entered UserName yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(strPassword))
            {
                MessageBox.Show("You haven't entered Password yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            if ((strUserName != "lamnd" || strPassword != "lam021103") && (strUserName != "user1" || strPassword != "123456789"))
            {
                MessageBox.Show("UserName or Password not true", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (strUserName == "lamnd" && strPassword == "lam021103")
                Form7.permisson = "Admin";
            else Form7.permisson = "User";
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Form7 objForm7 = new Form7();
                objForm7.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
