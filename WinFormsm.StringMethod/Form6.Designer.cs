﻿namespace WinFormsm.StringMethod
{
    partial class Form6
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(236, 129);
            button1.TabIndex = 0;
            button1.Text = "แยกชื่อ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 175);
            button2.Name = "button2";
            button2.Size = new Size(236, 131);
            button2.TabIndex = 1;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(272, 12);
            button3.Name = "button3";
            button3.Size = new Size(236, 131);
            button3.TabIndex = 2;
            button3.Text = "วาดรูป";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button4.Location = new Point(272, 174);
            button4.Name = "button4";
            button4.Size = new Size(236, 132);
            button4.TabIndex = 3;
            button4.Text = "หาค่าเฉลี่ย";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button5.Location = new Point(154, 324);
            button5.Name = "button5";
            button5.Size = new Size(236, 119);
            button5.TabIndex = 4;
            button5.Text = "เรียงลำดับ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(236, 129);
            button6.TabIndex = 0;
            button6.Text = "แยกชื่อ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button7.Location = new Point(12, 175);
            button7.Name = "button7";
            button7.Size = new Size(236, 131);
            button7.TabIndex = 1;
            button7.Text = "สูตรคำนวณ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button2_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button8.Location = new Point(272, 12);
            button8.Name = "button8";
            button8.Size = new Size(236, 131);
            button8.TabIndex = 2;
            button8.Text = "วาดรูป";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(529, 464);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(button1);
            Name = "Form6";
            Text = "เมนู";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}