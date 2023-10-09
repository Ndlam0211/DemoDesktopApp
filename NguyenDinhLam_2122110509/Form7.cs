using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace NguyenDinhLam_2122110509
{
    public partial class Form7 : Form
    {
        List<Student> students;
        public Form7()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        public void lockControl()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSort.Enabled = false;
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("You haven't entered student id yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("You haven't entered name yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("You haven't entered grade yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGrade.Focus();
                return false;
            }
            return true;
        }

        public bool checkId()
        {
            int id = int.Parse(txtID.Text);

            bool isExist = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == id)
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist)
            {
                MessageBox.Show("ID already exists.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isExist;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                int id;
                string name;
                float grade;
                string cl;
                string adress;
                //if (!int.TryParse(txtID.Text, out id))
                //{
                //    MessageBox.Show("id must be a string of intergers", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                try
                {
                    id = Int32.Parse(txtID.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("id must be a string of intergers", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (checkId())
                {
                    return;
                }

                //Regex regex = new Regex(@"^[a-zA-zàáâãèéêìíòóôõùúûýýñç ]+$");
                //if (!regex.IsMatch(txtName.Text))
                //{
                //    // Nếu sai thì in ra lỗi
                //    MessageBox.Show("name must be alphabet and space", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                try
                {
                    grade = float.Parse(txtGrade.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Grade must be a number", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (grade<0 || grade > 10)
                {
                    MessageBox.Show("Grade must from 0 to 10", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                name = txtName.Text;
                cl = txtClass.Text;
                adress = txtAdress.Text;
                Student student = new Student(id, name, cl, adress, grade);
                students.Add(student);

                txtID.Text = null;
                txtName.Text = null;
                txtGrade.Text = null;
                txtClass.Text = null;
                txtAdress.Text = null;

                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = students;
            }
        }

        int index;

        private void dataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >=0)
            {
                txtID.Text = students[index].ID.ToString();
                txtName.Text = students[index].Name;
                txtClass.Text = students[index].Class;
                txtAdress.Text = students[index].Adress;
                txtGrade.Text = students[index].Grade.ToString();
                //if (students[index].Image != null)
                //{
                //    ptrAvatar.Image = students[index].Image;
                //}
                //else
                //{
                //    ptrAvatar.Image = null;
                //}
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you certainly change?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (checkId())
                {
                    return;
                }
                students[index].ID = Int32.Parse(txtID.Text);
                students[index].Name = txtName.Text;
                students[index].Class = txtClass.Text;
                students[index].Adress = txtAdress.Text;
                students[index].Grade = float.Parse(txtGrade.Text);
                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = students;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you certainly remove?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                students.RemoveAt(index);
                txtID.Text = null;
                txtName.Text = null;
                txtGrade.Text = null;
                txtClass.Text = null;
                txtAdress.Text = null;
                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = students;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            students.Sort((a, b) => a.Grade.CompareTo(b.Grade));
            dataGridStudent.DataSource = null;
            dataGridStudent.DataSource = students;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = students;
                List<Student> tmp = new List<Student>();
                for (int i = 0; i < dataGridStudent.Rows.Count; i++)
                {
                    if (dataGridStudent.Rows[i].Cells[1].Value.ToString().ToLower().Contains(value.ToLower()))
                    {
                        tmp.Add(students[i]);
                    }   
                }
                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = tmp;
            }
            else
            {
                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = students;
            }
        }

        public static String permisson;
        private void Form7_Load(object sender, EventArgs e)
        {
            if (Form7.permisson == "Admin")
                MessageBox.Show("Login success, welcome back lamnd (Admin)", "Notification", MessageBoxButtons.OK, MessageBoxIcon.None);
            else
            {
                MessageBox.Show("Login success, welcome back user1 (User)", "Notification", MessageBoxButtons.OK, MessageBoxIcon.None);
                lockControl();
            }
        }
        //internal void AssignImage(Student student, Image image)
        //{
        //    student.Image = image;
        //}

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            ptrAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "All Images (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(dlg.FileName);
                if (fileInfo.Length > 3 * 1024 * 1024) // 3MB
                {
                    // Display an error message
                    MessageBox.Show("The file size is too large. Please upload a file under 3MB.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
                ptrAvatar.ImageLocation = dlg.FileName;
                //AssignImage(students[index], ptrAvatar.Image);
            }
        }

    }
    class Student
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public float Grade { set; get; }
        public string Class { set; get; }
        public string Adress { set; get; }
        //public Image Image { set; get; }


        public Student()
        {
            ID = 0;
            Name = string.Empty;
            Grade = 0;
            Class= string.Empty;
            Adress = string.Empty;
        }

        public Student(int id, string name, string cl, string adress, float grade)
        {
            ID = id;
            Name = name;
            Grade = grade;
            Class = cl;
            Adress = adress;
        }
    }
}
