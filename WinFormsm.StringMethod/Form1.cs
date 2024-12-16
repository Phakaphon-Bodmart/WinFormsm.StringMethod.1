namespace WinFormsm.StringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName = "", firstname = "", lastname1 = "", title = "";
            int x = 0;
            //กำจัด Space หน้าสุดและหลังสุดออก
            fullName = txtFullName.Text.Trim();
            //ตรวจสอบว่ามีคำนำหน้าที่ต้องการหรือไม่ "นางสาว", "นาง", "นาย"
            //ตัดคำนำหน้า ออกไปแสดงผล 
            if (fullName.StartsWith("นางสาว"))
            {
                x = 6;        //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กหญิง"))
            {
                x = 8;         //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("เด็กชาย"))
            {
                x = 7;         //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("นาง") || fullName.StartsWith("นาย"))
            {
                x = 3;         //ตำแหน่งที่ต้องการแยก
                title = fullName.Substring(0, x);
            }
            else
            {
                x = fullName.LastIndexOf('.') + 1;
                title = fullName.Substring(0, x);
            }
            fullName = fullName.Substring(x).Trim();
            //หาตำแหน่งช่องว่างระหว่างชื่อและสกุล
            x = fullName.IndexOf(' ');

            //ตัดตั้งแต่ตัวที่ 0 จนถึงตำแหน่งช่องว่างจะได้ชื่อ
            firstname = fullName.Substring(0, x).Trim();
            //ตัดตั้งแต่ตำแหน่งช่องว่าง ไปจนหมดข้อความจะได้นามสกุล
            lastname1 = fullName.Substring(x).Trim();



            //แสดงผลใน Textbox
            txtTitle.Text = title;
            txtFirstName.Text = firstname;
            txtLastName.Text = lastname1;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "นาย ภัคพล บทมาตย์";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "เด็กชาย ภัคพล บทมาตย์";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "ภัคพล บทมาตย์";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "นาย ภัคพล บท มาตย์";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "รศ.ดร.ภัคพล บทมาตย์";

        }
    }
}
