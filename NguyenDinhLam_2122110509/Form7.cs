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
    public partial class Form7 : Form
    {
        List<Student> students;
        public Form7()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        public bool CheckControl()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("You haven't entered your student id yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("You haven't entered your name yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("You haven't entered your grade yet.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGrade.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                int id;
                string name;
                float grade;
                id = Int32.Parse(txtID.Text);
                name = txtName.Text;
                grade = float.Parse(txtGrade.Text);
                Student student = new Student(id, name, grade);
                students.Add(student);
                dataGridStudent.DataSource = students;
            }
        }
    }
    class Student
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public float Grade { set; get; }

        public Student()
        {
            ID = 0;
            Name = string.Empty;
            Grade = 0;
        }

        public Student(int id, string name, float grade)
        {
            ID = id;
            Name = name;
            Grade = grade;
        }
    }
}
