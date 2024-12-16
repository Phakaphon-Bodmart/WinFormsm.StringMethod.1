namespace WinFormsm.StringMethod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtTitle = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnSplitName = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(164, 65);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(552, 34);
            txtFullName.TabIndex = 0;
            txtFullName.Text = "...";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(164, 177);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(306, 34);
            txtTitle.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(164, 230);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(306, 34);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(164, 281);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(306, 34);
            txtLastName.TabIndex = 0;
            // 
            // btnSplitName
            // 
            btnSplitName.BackColor = Color.Aqua;
            btnSplitName.Location = new Point(759, 57);
            btnSplitName.Margin = new Padding(2);
            btnSplitName.Name = "btnSplitName";
            btnSplitName.Size = new Size(123, 50);
            btnSplitName.TabIndex = 1;
            btnSplitName.Text = "แยกชื่อสกุล";
            btnSplitName.UseVisualStyleBackColor = false;
            btnSplitName.Click += btnSplitName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(35, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 2;
            label1.Text = "ชื่อ-นามสกุล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(50, 183);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 2;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(50, 236);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 28);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(50, 287);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 2;
            label4.Text = "นามสกุล";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Salmon;
            btn1.Font = new Font("Segoe UI", 10.2F);
            btn1.Location = new Point(618, 183);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(123, 50);
            btn1.TabIndex = 3;
            btn1.Text = "นาย-นาง";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Salmon;
            btn2.Font = new Font("Segoe UI", 10.2F);
            btn2.Location = new Point(759, 183);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(123, 50);
            btn2.TabIndex = 4;
            btn2.Text = "ดช.-ดญ.";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Salmon;
            btn3.Font = new Font("Segoe UI", 10.2F);
            btn3.Location = new Point(618, 255);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(123, 50);
            btn3.TabIndex = 5;
            btn3.Text = "ไม่มีคำนำหน้า";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Salmon;
            btn4.Font = new Font("Segoe UI", 10.2F);
            btn4.Location = new Point(759, 255);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(123, 50);
            btn4.TabIndex = 6;
            btn4.Text = "ช่องว่างสกุล";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Salmon;
            btn5.Font = new Font("Segoe UI", 10.2F);
            btn5.Location = new Point(692, 324);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(123, 50);
            btn5.TabIndex = 7;
            btn5.Text = "มีจุด";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(956, 491);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSplitName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtTitle);
            Controls.Add(txtFullName);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "แยกชื่อ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSplitName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
    }
}
