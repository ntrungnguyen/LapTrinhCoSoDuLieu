using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Demo
{
	public partial class frmTimThongTin : Form
	{
		public List<GiaoVien> dsGV;
		public GiaoVien gv;
		public frmTimThongTin(QuanLyGiaoVien qlgv)
		{
			dsGV = qlgv.dsGiaoVien;
			InitializeComponent();
		}
		
		private void rdbtnMaGV_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is RadioButton)
			{
				RadioButton radioButton = (RadioButton)sender;
				if (rdbtnMaGV.Checked)
				{
					label1.Text = rdbtnMaGV.Text;
				}
			}
		}

		private void rdbtnHoTen_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is RadioButton)
			{
				RadioButton radioButton = (RadioButton)sender;
				if (rdbtnHoTen.Checked)
				{
					label1.Text = rdbtnHoTen.Text;
				}
			}
		}

		private void rdbtnSDT_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is RadioButton)
			{
				RadioButton radioButton = (RadioButton)sender;
				if (rdbtnSDT.Checked)
				{
					label1.Text = rdbtnSDT.Text;
				}
			}
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			var timkiem = txtTimKiem.Text;
			if (rdbtnMaGV.Checked == true)
			{
				GiaoVien kq = dsGV.Find(x => x.MaSo.Trim() == timkiem.Trim());
				if (kq == null)
				{
					MessageBox.Show("Không tìm thấy thông tin!", "Lỗi");
				}
				else
				{
					frmTBGiaoVien frm = new frmTBGiaoVien();
					frm.SetText(kq.ToString());
					frm.ShowDialog();
				}
			}
			if (rdbtnHoTen.Checked == true)
			{
				GiaoVien kq = dsGV.Find(x => x.HoTen.ToLower().Trim() == timkiem.ToLower().Trim());
				if (kq == null)
				{
					MessageBox.Show("Không tìm thấy thông tin!", "Lỗi");
				}
				else
				{
					frmTBGiaoVien frm = new frmTBGiaoVien();
					frm.SetText(kq.ToString());
					frm.ShowDialog();
				}
			}
			if (rdbtnSDT.Checked == true)
			{
				GiaoVien kq = dsGV.Find(x => x.SoDT.Trim() == timkiem.Trim());
				if (kq == null)
				{
					MessageBox.Show("Không tìm thấy thông tin!", "Lỗi");
				}
				else
				{
					frmTBGiaoVien frm = new frmTBGiaoVien();
					frm.SetText(kq.ToString());
					frm.ShowDialog();
				}
			}
		}
	}
}
