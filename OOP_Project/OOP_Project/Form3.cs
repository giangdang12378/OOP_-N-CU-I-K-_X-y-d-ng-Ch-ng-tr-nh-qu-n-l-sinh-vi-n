using projekt;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV_Win
{
     
 

    public partial class Form3 : Form
    {
        private StudentManagementSystem studentManager = StudentManagementSystem.GetManagerState();

        public Form3()
        {
            InitializeComponent();
          
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if studentManager is initialized
                if (studentManager == null)
                {
                    MessageBox.Show("studentManager is not initialized.", "Error");
                    return;
                }

                string gender = "";
                if (this.checkBox1.Checked) { gender = "Male"; }
                else { gender = "Female"; }

                string departmentID = "";
                if (this.department.Text == "KQM") { departmentID = "1"; }
                else if (this.department.Text == "KQM") { departmentID = "1"; }
                else { departmentID = "3"; }

                Student newStudent = new Student
                {
                    Id = id.Text,
                    Name = name.Text,
                    Email = email.Text,
                    PhoneNumber = phone.Text,
                    Birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Gender = gender,
                    CourseIDs = courseID.Text.Split(",").ToList(),
                    DepartmentID = departmentID,
                    ClassID = classID.Text,
                };

                studentManager.AddStudent(newStudent);
                MessageBox.Show("Student added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
