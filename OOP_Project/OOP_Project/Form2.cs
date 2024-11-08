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

namespace QLSV_Win
{
    public partial class Form2 : Form
    {
        StudentManagementSystem StudentManager = StudentManagementSystem.GetManagerState();
        private Student currentStudent;  // Đối tượng sinh viên hiện tại

        // Constructor nhận đối tượng Student
        public Form2(Student student)
        {
            InitializeComponent();
            currentStudent = student;
            DisplayStudentInfo();  // Hiển thị thông tin sinh viên
        }
        // Hiển thị thông tin sinh viên lên các TextBox
        private void DisplayStudentInfo()
        {
            if (currentStudent != null)
            {
                mssv.Text = currentStudent.Id;
                name.Text = currentStudent.Name;
                clas.Text = currentStudent.ClassID;
                schoolyear.Text = currentStudent.DepartmentID;
                gender.Text = currentStudent.Gender;
                phone.Text = currentStudent.PhoneNumber;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá trị của giới tính
                string gender = this.gender.Text.Trim(); // Lấy và loại bỏ khoảng trắng 

                // Kiểm tra giới tính có phải là "Nam" hoặc "Nữ" không
                if (gender != "Male" && gender != "Female")
                {
                    // Nếu không phải, ném một ngoại lệ
                    throw new ArgumentException("Giới tính phải là 'Male' hoặc 'Female'.");
                }

                // Nếu giới tính hợp lệ, cập nhật thông tin sinh viên
                currentStudent.Id = mssv.Text;                  // MSSV
                currentStudent.Name = name.Text;                // Tên
                currentStudent.ClassID = clas.Text;             // Mã Lớp
                currentStudent.DepartmentID = schoolyear.Text;        // Mã Khóa
                currentStudent.Gender = gender;                     // Giới tính
                currentStudent.PhoneNumber = phone.Text;               // Phone

                // (Tùy chọn) Bạn có thể hiển thị thông báo xác nhận
                StudentManager.AddStudent(currentStudent);
                MessageBox.Show("Thông tin sinh viên đã được cập nhật.");
            }
            catch (ArgumentException ex)
            {
                // Xử lý ngoại lệ khi giới tính không hợp lệ
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi khác
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
