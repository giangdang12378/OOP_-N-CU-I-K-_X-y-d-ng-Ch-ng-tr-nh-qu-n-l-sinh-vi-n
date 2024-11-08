namespace QLSV_Win
{
    partial class Form2
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
            mssv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            name = new TextBox();
            clas = new TextBox();
            schoolyear = new TextBox();
            label6 = new Label();
            gender = new TextBox();
            phone = new TextBox();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(37, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 1;
            label1.Text = "Thông Tin Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "MSSV:";
            label2.Click += label2_Click;
            // 
            // mssv
            // 
            mssv.Location = new Point(85, 64);
            mssv.Margin = new Padding(2, 2, 2, 2);
            mssv.Name = "mssv";
            mssv.Size = new Size(158, 23);
            mssv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 103);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "Mã Lớp:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 141);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 6;
            label5.Text = "Khoa:";
            // 
            // name
            // 
            name.Location = new Point(85, 98);
            name.Margin = new Padding(2, 2, 2, 2);
            name.Name = "name";
            name.Size = new Size(184, 23);
            name.TabIndex = 7;
            // 
            // clas
            // 
            clas.Location = new Point(407, 101);
            clas.Margin = new Padding(2, 2, 2, 2);
            clas.Name = "clas";
            clas.Size = new Size(141, 23);
            clas.TabIndex = 8;
            // 
            // schoolyear
            // 
            schoolyear.Location = new Point(407, 139);
            schoolyear.Margin = new Padding(2, 2, 2, 2);
            schoolyear.Name = "schoolyear";
            schoolyear.Size = new Size(141, 23);
            schoolyear.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 137);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Giới tính:";
            // 
            // gender
            // 
            gender.Location = new Point(85, 137);
            gender.Margin = new Padding(2, 2, 2, 2);
            gender.Name = "gender";
            gender.Size = new Size(87, 23);
            gender.TabIndex = 12;
            // 
            // phone
            // 
            phone.Location = new Point(85, 172);
            phone.Margin = new Padding(2, 2, 2, 2);
            phone.Name = "phone";
            phone.Size = new Size(192, 23);
            phone.TabIndex = 15;
            phone.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(494, 279);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(112, 42);
            button1.TabIndex = 17;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 173);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 18;
            label7.Text = "Phone:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 372);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(phone);
            Controls.Add(gender);
            Controls.Add(label6);
            Controls.Add(schoolyear);
            Controls.Add(clas);
            Controls.Add(name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mssv);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mssv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox clas;
        private System.Windows.Forms.TextBox schoolyear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private Label label7;
    }
}