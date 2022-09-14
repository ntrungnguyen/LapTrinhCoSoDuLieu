using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
	public partial class frmPictureView : Form
	{
		int count = 0;
		public frmPictureView()
		{
			InitializeComponent();
			
			
		}

		private void frmPictureView_Load(object sender, EventArgs e)
		{
			
		}

		// New
		private void tsmiNew_Click(object sender, EventArgs e)
		{
			DialogResult dlg = this.openFileDlg.ShowDialog();
			if (dlg == DialogResult.OK)
			{
				frmPicture frm = new frmPicture(openFileDlg.FileName);
				frm.MdiParent = this;
				count++;
				frm.Text = "Picture -" + count + "-" + openFileDlg.FileName;
				frm.Show();
			}
			this.tsmiStatusStrip.Text = "Tổng số Form con: " + count.ToString();
		}


		//Save As
		private void tsmiSaveAs_Click(object sender, EventArgs e)
		{
			DialogResult dlg = this.saveFileDlg.ShowDialog();
			if (dlg == DialogResult.OK)
			{
				frmPicture frm = this.ActiveMdiChild as frmPicture;
				try
				{
					Image img = frm.pbHinh.Image;
					img.Save(saveFileDlg.FileName, ImageFormat.Bmp);
				}
				catch
				{
					MessageBox.Show("Lỗi lưu file");
				}
			}
		}

		//Exit
		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		//ToolStrip
		private void tsmiToolStrip_Click(object sender, EventArgs e)
		{
			bool check = this.tsmiToolStrip.Checked;
			if (check)
			{
				this.tsmiToolStrip.Visible = true;
			}
			else
			{
				this.tsmiToolStrip.Visible = false;
			}
		}

		//statusstrip
		private void tsmiStatusStrip_Click(object sender, EventArgs e)
		{
			bool check = this.tsmiStatusStrip.Checked;
			if (check)
			{
				this.tsmiStatusStrip.Visible = true;
			}
			else
			{
				this.tsmiStatusStrip.Visible = false;
			}
		}

		//Arrangecons
		private void tsmiArrangecons_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}

		//cascade
		private void tsmiCascade_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		//Horizontal
		private void tsmiHorizontal_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}


		//Vertical
		private void tsmiVertical_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		//Maximize
		private void tsmiMaximize_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Maximized;
			}
		}

		//Minimize
		private void tsmiMinimiza_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Minimized;
			}
		}

		//3 chức năng
		private void tstZoomIn_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Maximized;
			}
		}

		private void tstZoomout_Click(object sender, EventArgs e)
		{
			foreach (Form frm in this.MdiChildren)
			{
				frm.WindowState = FormWindowState.Minimized;
			}
		}

		private void tstEdit_Click(object sender, EventArgs e)
		{
			Process.Start("mspaint", this.pbHinh.ImageLocation); 
		}

		
	}
}
