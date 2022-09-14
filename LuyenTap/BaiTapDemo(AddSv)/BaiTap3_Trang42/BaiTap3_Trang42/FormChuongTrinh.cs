using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3_Trang42
{
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            label1.Text = "Đã đăng nhập";
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm sinh viên vào danh sách hay không ?",
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbDanhSachSV.Items.Add(txtFullname.Text);
            }  
        }
    }
}
