namespace WinFormsm.StringMethod
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
            txtNum1 = new TextBox();
            lblMulti = new Label();
            lblNum = new Label();
            txtMulti1 = new TextBox();
            btnNum = new Button();
            txtNum2 = new TextBox();
            txtMulti2 = new TextBox();
            btnMulti = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtNum1.Location = new Point(35, 101);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(149, 140);
            txtNum1.TabIndex = 0;
            // 
            // lblMulti
            // 
            lblMulti.BackColor = Color.BlanchedAlmond;
            lblMulti.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMulti.ForeColor = Color.Blue;
            lblMulti.Location = new Point(625, 98);
            lblMulti.Name = "lblMulti";
            lblMulti.Size = new Size(149, 281);
            lblMulti.TabIndex = 1;
            lblMulti.Text = "....";
            // 
            // lblNum
            // 
            lblNum.BackColor = Color.BlanchedAlmond;
            lblNum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum.ForeColor = Color.Blue;
            lblNum.Location = new Point(216, 101);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(149, 281);
            lblNum.TabIndex = 2;
            lblNum.Text = ".....";
            // 
            // txtMulti1
            // 
            txtMulti1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtMulti1.Location = new Point(448, 98);
            txtMulti1.Multiline = true;
            txtMulti1.Name = "txtMulti1";
            txtMulti1.Size = new Size(149, 143);
            txtMulti1.TabIndex = 4;
            // 
            // btnNum
            // 
            btnNum.Location = new Point(139, 26);
            btnNum.Name = "btnNum";
            btnNum.Size = new Size(128, 58);
            btnNum.TabIndex = 6;
            btnNum.Text = "หา %";
            btnNum.UseVisualStyleBackColor = true;
            btnNum.Click += btnNum_Click;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtNum2.Location = new Point(35, 247);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(149, 140);
            txtNum2.TabIndex = 8;
            // 
            // txtMulti2
            // 
            txtMulti2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtMulti2.Location = new Point(448, 247);
            txtMulti2.Multiline = true;
            txtMulti2.Name = "txtMulti2";
            txtMulti2.Size = new Size(149, 143);
            txtMulti2.TabIndex = 9;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(550, 26);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(128, 58);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "หาผลคูณ";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMulti);
            Controls.Add(txtMulti2);
            Controls.Add(txtNum2);
            Controls.Add(btnNum);
            Controls.Add(txtMulti1);
            Controls.Add(lblNum);
            Controls.Add(lblMulti);
            Controls.Add(txtNum1);
            Name = "Form2";
            Text = "สูตรคำนวณ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lblMulti;
        private Label lblNum;
        private TextBox txtMulti1;
        private Button btnNum;
        private TextBox txtNum2;
        private TextBox txtMulti2;
        private Button btnMulti;
    }
}