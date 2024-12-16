using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsm.StringMethod
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int Multiply(int a, int b)
        {
            return a * b;
        }

        private int Modulus(int a, int b)
        {
            return a % b;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtMulti1.Text);
            int num2 = int.Parse(txtMulti2.Text);
            int product = Multiply(num1, num2);

            lblMulti.Text = $"ผลคูณของ {num1} และ {num2} คือ {product}\n";
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int remainder = Modulus(num1, num2);

            lblNum.Text = $"เศษเหลือจาก {num1} หารด้วย {num2} คือ {remainder}";
        }
    }
}
