namespace QLSV_Win
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            classID = new TextBox();
            courseID = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            email = new TextBox();
            label8 = new Label();
            phone = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            schoolyear = new TextBox();
            department = new TextBox();
            id = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(80, 46);
            label1.Name = "label1";
            label1.Size = new Size(184, 29);
            label1.TabIndex = 1;
            label1.Text = "Thêm Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(410, 114);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Giới Tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(49, 160);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(410, 157);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 5;
            label4.Text = "Khóa";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(76, 114);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 6;
            label5.Text = "Tên";
            label5.Click += label5_Click;
            // 
            // name
            // 
            name.Font = new Font("Microsoft Sans Serif", 10F);
            name.Location = new Point(124, 111);
            name.Name = "name";
            name.Size = new Size(210, 26);
            name.TabIndex = 9;
            // 
            // classID
            // 
            classID.Font = new Font("Microsoft Sans Serif", 10F);
            classID.Location = new Point(124, 157);
            classID.Name = "classID";
            classID.Size = new Size(88, 26);
            classID.TabIndex = 10;
            // 
            // courseID
            // 
            courseID.Font = new Font("Microsoft Sans Serif", 10F);
            courseID.Location = new Point(468, 157);
            courseID.Name = "courseID";
            courseID.Size = new Size(120, 26);
            courseID.TabIndex = 11;
            courseID.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10F);
            button1.Location = new Point(600, 351);
            button1.Name = "button1";
            button1.Size = new Size(164, 54);
            button1.TabIndex = 12;
            button1.Text = "Thêm Sinh Viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(501, 116);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(55, 199);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 14;
            label6.Text = "MSSV";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.Location = new Point(409, 199);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 15;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // email
            // 
            email.Font = new Font("Microsoft Sans Serif", 10F);
            email.Location = new Point(468, 199);
            email.Name = "email";
            email.Size = new Size(249, 26);
            email.TabIndex = 17;
            email.TextChanged += textBox5_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.Location = new Point(52, 245);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 18;
            label8.Text = "Phone ";
            // 
            // phone
            // 
            phone.Font = new Font("Microsoft Sans Serif", 10F);
            phone.Location = new Point(124, 245);
            phone.Name = "phone";
            phone.Size = new Size(210, 26);
            phone.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.Location = new Point(371, 250);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 20;
            label9.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 10F);
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10F);
            dateTimePicker1.Location = new Point(468, 247);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 26);
            dateTimePicker1.TabIndex = 22;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F);
            label10.Location = new Point(38, 293);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 23;
            label10.Text = "Năm học";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F);
            label11.Location = new Point(391, 293);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 24;
            label11.Text = "Khoa";
            // 
            // schoolyear
            // 
            schoolyear.Font = new Font("Microsoft Sans Serif", 10F);
            schoolyear.Location = new Point(124, 293);
            schoolyear.Name = "schoolyear";
            schoolyear.Size = new Size(88, 26);
            schoolyear.TabIndex = 25;
            // 
            // department
            // 
            department.Font = new Font("Microsoft Sans Serif", 10F);
            department.Location = new Point(468, 293);
            department.Name = "department";
            department.Size = new Size(210, 26);
            department.TabIndex = 26;
            department.TextChanged += textBox8_TextChanged;
            // 
            // id
            // 
            id.Font = new Font("Microsoft Sans Serif", 10F);
            id.Location = new Point(124, 199);
            id.Name = "id";
            id.Size = new Size(173, 26);
            id.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 466);
            Controls.Add(department);
            Controls.Add(schoolyear);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(phone);
            Controls.Add(label8);
            Controls.Add(email);
            Controls.Add(id);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(courseID);
            Controls.Add(classID);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox classID;
        private System.Windows.Forms.TextBox courseID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox schoolyear;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox id;
    }
}

