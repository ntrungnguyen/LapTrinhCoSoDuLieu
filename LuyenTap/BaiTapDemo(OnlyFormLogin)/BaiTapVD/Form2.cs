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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Form1 login = new Form1();
			if (login.ShowDialog() != DialogResult.OK)
			{
				Application.Exit();
			}
			lbLoad.Text = "Đã đăng nhập.";
		}
	}
}
