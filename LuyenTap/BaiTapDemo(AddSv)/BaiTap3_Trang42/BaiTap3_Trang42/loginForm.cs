using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTap3_Trang42
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bdnLogin_Click(object sender, EventArgs e)
        {
            var loginName = txtLoginName.Text;
            var password = txtpassword.Text;

            if(loginName.CompareTo("a") == 0 && password.CompareTo("1") == 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblMessenger.Text = "Sai tên đăng nhập hoặc mất mật khẩu.";

            }    
        }

        private void lblMessenger_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
