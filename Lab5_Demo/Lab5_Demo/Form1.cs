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
	public partial class Form1 : Form
	{
		QuanLySinhVien qlsv;
		List<SinhVien> dssv;
		private bool checkChange = true;
		public Form1()
		{
			InitializeComponent();
		}

		private void LoadListView(List<SinhVien> dSSinhVien)
		{
			this.lvDSSV.Items.Clear();
			foreach (SinhVien sv in qlsv.DSSinhVien)
			{
				ThemSV(sv);
			}
		}
	
		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MSSV);
			lvitem.SubItems.Add(sv.HoTenLot);
			lvitem.SubItems.Add(sv.Ten);
			string gt = "Nữ";
			if (sv.GioiTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.Lop);
			lvitem.SubItems.Add(sv.CMND);
			lvitem.SubItems.Add(sv.SDT);
			lvitem.SubItems.Add(sv.DiaChi);
			string mh = "";
			foreach (string s in sv.MonHoc)
			{
				mh += s + ",";
			}
			mh = mh.Substring(0, mh.Length - 1);
			lvitem.SubItems.Add(mh);
			this.lvDSSV.Items.Add(lvitem);
		}

		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			List<string> MonHoc = new List<string>();
			sv.MSSV = this.mtbMSSV.Text;
			sv.HoTenLot = this.tbTenLot.Text;
			sv.Ten = this.tbTen.Text;
			if (rdNu.Checked == true)
			{
				gt = false;
			}
			sv.GioiTinh = gt;
			
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.Lop = this.cbbLop.Text;
			sv.CMND = this.mtbCMND.Text;
			sv.SDT = this.mtbSDT.Text;
			sv.DiaChi = this.tbDiaChi.Text;

			for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
			{
				if (clbMonHoc.GetItemChecked(i))
				{
					MonHoc.Add(clbMonHoc.Items[i].ToString());
				}
			}
			sv.MonHoc = MonHoc;

			return sv;
		}

		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MSSV = lvitem.SubItems[0].Text;
			sv.HoTenLot = lvitem.SubItems[1].Text;
			sv.Ten = lvitem.SubItems[2].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[3].Text == "Nam")
				sv.GioiTinh = true;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[4].Text);
			sv.Lop = lvitem.SubItems[5].Text;
			sv.CMND = lvitem.SubItems[6].Text;
			sv.SDT = lvitem.SubItems[7].Text;
			sv.DiaChi = lvitem.SubItems[8].Text;
			List<string> monhoc = new List<string>();
			string[] s = lvitem.SubItems[9].Text.Split(',');
			for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
			{
				this.clbMonHoc.SetItemChecked(i, false);
			}
			foreach (string t in s)
			{
				monhoc.Add(t.Trim());
			}
			sv.MonHoc = monhoc;

			return sv;
		}

		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtbMSSV.Text = sv.MSSV;
			this.tbTenLot.Text = sv.HoTenLot;
			this.tbTen.Text = sv.Ten;
			if (sv.GioiTinh)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;
			this.dtpNgaySinh.Value = sv.NgaySinh;
			this.cbbLop.Text = sv.Lop;
			this.mtbCMND.Text = sv.CMND;
			this.mtbSDT.Text = sv.SDT;
			this.tbDiaChi.Text = sv.DiaChi;

			foreach (var item in sv.MonHoc)
			{
				for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
				{
					if (item.CompareTo(this.clbMonHoc.Items[i]) == 0)
					{
						this.clbMonHoc.SetItemChecked(i, true);
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			qlsv = new QuanLySinhVien();
			LoadListView(qlsv.GetSinhViens());
			dssv = qlsv.DSSinhVien;
		}

		private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvDSSV.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
				SinhVien sv = GetSinhVienLV(lvitem);
				ThietLapThongTin(sv);
			}
		}

		private void LoadCheckListBox(SinhVien sv)
		{
			this.clbMonHoc.Items.Clear();
			foreach (var item in sv.MonHoc)
			{
				clbMonHoc.Items.Add(item);
			}
		}

		private bool checkMonHoc()
		{
			int monHoc = 0;
			for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
			{
				monHoc += 1;
			}

			if (monHoc > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			TimKiem timkiem = new TimKiem(qlsv);
			timkiem.ShowDialog();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (checkChange)
			{
				DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialog == DialogResult.Yes)
				{
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		private bool kiemtraMH()
		{
			int monhoc = 0;
			for (int i = 0; i < this.clbMonHoc.Items.Count; i++)
			{
				monhoc += 1;
			}
			if (monhoc > 0)
			{
				return true;
			}
			else
				return false;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (this.mtbMSSV.Text == "" || this.tbTenLot.Text == "" || this.tbTen.Text == "" || this.mtbCMND.Text == "" || this.mtbSDT.Text == "" || this.cbbLop.Text == ""
				|| this.tbDiaChi.Text == "" || kiemtraMH() == false)
			{
				MessageBox.Show("Bạn cần nhập đầy đủ thông tin trước khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				for (int i = 0; i <dssv.Count; i++)
				{
					if(dssv[i].MSSV == this.mtbMSSV.Text)
					{
						MessageBox.Show("Mã số sinh viên bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				SinhVien sv = GetSinhVien();
				this.qlsv.Them(sv);
				MessageBox.Show("Lưu thành công", "Thông báo");
				qlsv.Luu();
				LoadListView(qlsv.DSSinhVien);
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (this.mtbMSSV.Text == "" || this.tbTenLot.Text == "" || this.tbTen.Text == "" || this.cbbLop.Text == "" || this.mtbCMND.Text == ""
			   || this.mtbSDT.Text == "" || this.tbDiaChi.Text == "" || kiemtraMH() == false)
			{
				MessageBox.Show("Bạn phải nhập đầy đủ thông tin sinh viên trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				SinhVien sv = GetSinhVien();
				qlsv.Sua(sv);
				qlsv.Luu();
				LoadListView(qlsv.DSSinhVien);
			}
		}

		private void tsmiXoa_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem lvitem;
			count = this.lvDSSV.Items.Count - 1;

			for (i = count - 1; i >= 0; i--)
			{
				lvitem = this.lvDSSV.Items[i];
				if (lvitem.Checked)
				{
					qlsv.Xoa(lvitem.SubItems[0].Text);
				}
			}
			LoadListView(qlsv.DSSinhVien);
			//public void Xoa(string mssv)
			//{
			//	for (int i = this.DSSinhVien.Count - 1; i >= 0; i--)
			//	{
			//		if (DSSinhVien[i].MSSV == mssv)
			//			this.DSSinhVien.RemoveAt(i);
			//	}
			//}
		}

		private void tsmiThemMH_Click(object sender, EventArgs e)
		{
			ThemMonHoc them = new ThemMonHoc();
			var dialog = them.ShowDialog();
			if (dialog == DialogResult.OK)
			{
				string mh = them.monhoc;
				clbMonHoc.Items.Add(mh);
			}
		}

		private void tsmiXoaMH_Click(object sender, EventArgs e)
		{
			for (int i = this.clbMonHoc.Items.Count - 1; i >= 0; i--)
			{
				if (clbMonHoc.GetItemChecked(i))
				{
					clbMonHoc.Items.Remove(clbMonHoc.Items[i]);
				}
			}
			LoadListView(qlsv.DSSinhVien);
		}
	}
}
