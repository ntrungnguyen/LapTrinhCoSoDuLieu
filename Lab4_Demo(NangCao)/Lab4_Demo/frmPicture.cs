using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
	public partial class frmPicture : Form
	{
		Point p = new Point();

		public frmPicture()
		{
			InitializeComponent();
		}

		//Phương thức tạo lập frmPicture có tham số
		public frmPicture(String name)
		{
			InitializeComponent();
			this.pbHinh.ImageLocation = name;
			this.meniStrip1.Text = name;
		}


		//Load form
		private void frmPicture_Load(object sender, EventArgs e)
		{
			p = this.pbHinh.Location;
		}

		//Reload file hình
		private void tsmiReload_Click(object sender, EventArgs e)
		{
			DialogResult dlg = this.openFileDlg.ShowDialog();
			string title = "";
			if (dlg == DialogResult.OK)
			{
				title = this.Text.Substring(0, this.Text.LastIndexOf('-'))
					+ openFileDlg.FileName;
				this.Text = title;
				this.pbHinh.ImageLocation = openFileDlg.FileName;
			}
		}

		// Zoomin Zoomout
		private void tsmiZoomPlus_Click(object sender, EventArgs e)
		{
			this.pbHinh.Width += 50;
			this.pbHinh.Height += 50;
		}

		private void tsmiZoomMinus_Click(object sender, EventArgs e)
		{
			this.pbHinh.Width += 50;
			this.pbHinh.Height += 50;
		}


		//Scroll
		private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
		}

		private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
		}


		//Mở paint để sửa
		private void tsmiEdit_Click(object sender, EventArgs e)
		{
			Process.Start("mspaint", this.pbHinh.ImageLocation); 
		}
	}
}
