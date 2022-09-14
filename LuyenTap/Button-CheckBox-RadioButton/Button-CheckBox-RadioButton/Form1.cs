using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_CheckBox_RadioButton
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void chkMauChu_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkMauChu.Checked)
				this.btnButton.ForeColor = Color.Red;
			else
				this.btnButton.ForeColor = Color.Black;
		}

		private void chkMauNen_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkMauNen.Checked)
				this.btnButton.BackColor = Color.LightCyan;
			else
				this.btnButton.BackColor = this.btnFlat.BackColor;
		}

		private void rdFlat_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdFlat.Checked)
				this.btnFlat.FlatStyle = FlatStyle.Flat;
			else
				this.btnFlat.FlatStyle = FlatStyle.Popup;
		}
	}
}
