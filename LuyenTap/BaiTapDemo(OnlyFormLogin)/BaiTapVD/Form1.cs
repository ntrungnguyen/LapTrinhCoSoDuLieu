using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var loginName = txtBLoginName.Text;
			var password = txtBpassword.Text;

			if (loginName.CompareTo("a") == 0 && password.CompareTo("1") == 0)
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				lbMessage.Text = "Sai tên đăng nhập hoặc mật khẩu.";
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
