﻿using System;
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
                dataGridStudent.DataSource = null;
                dataGridStudent.DataSource = students;
                txtID.Text = null;
                txtName.Text = null;
                txtGrade.Text = null;
                txtClass.Text = null;
                txtAdress.Text = null;
            }
        }

        int index;

        private void dataGridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index>=0)
            {
                txtID.Text = students[index].ID.ToString();
                txtName.Text = students[index].Name;
                txtClass.Text = students[index].Class;
                txtAdress.Text = students[index].Adress;
                txtGrade.Text = students[index].Grade.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index>=0)
            {
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
    }
    class Student
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public float Grade { set; get; }
        public string Class { set; get; }
        public string Adress { set; get; }


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
