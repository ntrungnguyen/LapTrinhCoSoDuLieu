using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void bt1_Click(object sender, EventArgs e)
		{
			var loginName = bt1.Text;
			var password = bt2.Text;

			if (loginName.CompareTo("UserA") == 0 && password.CompareTo("1") == 0)
			{
				this.DialogResult = DialogResult.OK;
			}

			else
			{
				tB3.Text = "Sai tên đăng nhập hoặc mật khẩu";
			}
		}

		private void bt2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
