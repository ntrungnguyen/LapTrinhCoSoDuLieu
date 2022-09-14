using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Demo
{
	public partial class ThemMonHoc : Form
	{
		public string monhoc;
		public ThemMonHoc()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			monhoc = tbMonHoc.Text;
			this.DialogResult = DialogResult.OK;
		}
	}
}
