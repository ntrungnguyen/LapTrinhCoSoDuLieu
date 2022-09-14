using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void chkLBMonHoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			string s = "";
			for (int i = 0; i < chkLBMonHoc.Items.Count; i++)
			{
				if (this.chkLBMonHoc.GetItemChecked(i) == true)
					s += this.chkLBMonHoc.Items[i].ToString() + ", ";
			}
			MessageBox.Show("Danh sach mon hoc: " + s);
		}
	}
}
