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

namespace Lab2_Demo
{
	public partial class frmGiaoVien : Form
	{
		QuanLyGiaoVien qlgv;
		public frmGiaoVien()
		{
			
			InitializeComponent();
		}

		private void frmGiaoVien_Load(object sender, EventArgs e)
		{
			string lienhe = "http://dlu.edu.vn/";
			this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
			this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
			qlgv = new QuanLyGiaoVien();
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			int i = this.lbDanhSachMH.SelectedItems.Count - 1;
			while (i >= 0)
			{
				this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
				this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
				i--;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = this.lbMonHocDay.SelectedItems.Count - 1;
			while (i >= 0)
			{
				this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
				this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
				i--;
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Reset();
		}
		public void Reset()
		{
			this.cboMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.txtMail.Text = "";
			this.mtxtSoDT.Text = "";
			this.rdNam.Checked = true;

			//Bỏ chọn trên checkbox ngoại ngữ
			for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
			chklbNgoaiNgu.SetItemChecked(i, false);

			//chuyển các môn từ lbMonHocDay sang lbDanhMucMH
			foreach (object ob in this.lbMonHocDay.Items)
				this.lbDanhSachMH.Items.Add(ob);
			this.lbMonHocDay.Items.Clear();
		}

		private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string s = e.Link.LinkData.ToString();
			Process.Start(s);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			frmTBGiaoVien frm = new frmTBGiaoVien();
			frm.SetText(GetGiaoVien().ToString());
			frm.ShowDialog();
			
		}


		public GiaoVien GetGiaoVien()
		{
			string gt = "Nam";
			if (rdNu.Checked)
				gt = "Nữ";
			GiaoVien gv = new GiaoVien();
			gv.MaSo = this.cboMaSo.Text;
			gv.GioiTinh = gt;
			gv.HoTen = this.txtHoTen.Text;
			gv.NgaySinh = this.dtpNgaySinh.Value;
			gv.Mail = this.txtMail.Text;
			gv.SoDT = this.mtxtSoDT.Text;

			//Lấy thông tin ngoại ngữ
			string ngoaingu = "";
			for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
				if (chklbNgoaiNgu.GetItemChecked(i))
					ngoaingu += chklbNgoaiNgu.Items[i] + ";";
			gv.NgoaiNgu = ngoaingu.Split(';');

			//Lấy thông tin danh sách môn học
			DanhMucMonHoc mh = new DanhMucMonHoc();
			foreach (object ob in lbMonHocDay.Items)
				mh.Them(new MonHoc(ob.ToString()));
			gv.dsMonHoc = mh;

			return gv;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			frmTimThongTin frm = new frmTimThongTin(qlgv);
			frm.ShowDialog();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			GiaoVien gv = GetGiaoVien();
			GiaoVien kq = qlgv.Tim(gv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as GiaoVien).MaSo.CompareTo(obj1.ToString());
			});
			if (kq != null)
			{
				MessageBox.Show("Mã giáo viên đã tồn tại!","Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.qlgv.Add(gv);
				frmTBGiaoVien frm = new frmTBGiaoVien();
				frm.SetText(GetGiaoVien().ToString());
				frm.ShowDialog();
			}
		}
	}
}
