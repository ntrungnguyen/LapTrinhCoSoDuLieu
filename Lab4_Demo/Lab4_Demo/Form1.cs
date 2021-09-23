using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Demo
{
	public partial class Form1 : Form
	{
		public bool check = true;
		QuanLySinhVien qlsv;
		public Form1()
		{
			qlsv = new QuanLySinhVien();
			InitializeComponent();
		}
		private void LoadListView()
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in qlsv.DsSinhVien)
			{
				ThemSV(sv);
			}
		}
		public SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			sv.MaSo = this.mtbMSSV.Text;
			sv.HoTen = this.tbTen.Text;
			if (rdNu.Checked)
				gt = false;
			sv.GioiTinh = gt;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.Lop = this.cbLop.Text;
			sv.SoDienThoai = this.mtbSDT.Text;
			sv.Email = this.tbEmail.Text;
			sv.DiaChi = this.tbDiaChi.Text;
			sv.Hinh = this.tbHinh.Text;
			return sv;
		}

		//Thêm vào ds sv
		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MaSo);
			lvitem.SubItems.Add(sv.HoTen);
			string gt = "Nữ";
			if (sv.GioiTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.Lop);
			lvitem.SubItems.Add(sv.SoDienThoai);
			lvitem.SubItems.Add(sv.Email);
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}

		//Lấy thông tin từ ds sv
		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = lvitem.SubItems[0].Text;
			sv.HoTen = lvitem.SubItems[1].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[2].Text == "Nam")
				sv.GioiTinh = true;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
			sv.Lop = lvitem.SubItems[4].Text;
			sv.SoDienThoai = lvitem.SubItems[5].Text;
			sv.Email = lvitem.SubItems[6].Text;
			sv.DiaChi = lvitem.SubItems[7].Text;
			sv.Hinh = lvitem.SubItems[8].Text;
			return sv;
		}

		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtbMSSV.Text = sv.MaSo;
			this.tbTen.Text = sv.HoTen;
			if (sv.GioiTinh)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;
			this.dtpNgaySinh.Value = sv.NgaySinh;
			this.cbLop.Text = sv.Lop;
			this.mtbSDT.Text = sv.SoDienThoai;
			this.tbEmail.Text = sv.Email;
			this.tbDiaChi.Text = sv.DiaChi;
			this.tbHinh.Text = sv.Hinh;
		}

		private int SoSanhTheoMa(object obj1, object obj2)
		{
			SinhVien sv = obj2 as SinhVien;
			return sv.MaSo.CompareTo(obj1);
		}

		private void btnHinh_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Select Picture";
			dlg.Filter = "Image Files (*.bmp; *.jpg;*.png.)|";
			dlg.InitialDirectory = Environment.CurrentDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				var filename = dlg.FileName;
				tbHinh.Text = filename;
				pbHinh.Load(filename);
			}
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			this.mtbMSSV.Text = "";
			this.tbTen.Text = "";
			this.tbEmail.Text = "";
			this.tbDiaChi.Text = "";
			this.dtpNgaySinh.Value = DateTime.Now;
			this.rdNam.Checked = true;
			this.cbLop.Text = this.cbLop.Items[0].ToString();
			this.mtbSDT.Text = "";
			this.pbHinh.ImageLocation = "";
			this.tbHinh.Text = "";
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
			});
			if (kq == null)
			{
				this.qlsv.Them(sv);
				this.LoadListView();
			}
			else
			{
				bool kqsua;
				kqsua = qlsv.Sua(sv, sv.MaSo, delegate (object obj1, object obj2)
				{
					return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
				});
				this.LoadListView();
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			qlsv = new QuanLySinhVien();
			qlsv.DocFile();
			LoadListView();
		}

		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvSinhVien.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
				SinhVien sv = GetSinhVienLV(lvitem);
				ThietLapThongTin(sv);
			}
		}

		private void ctmsXoa_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem lvitem;
			count = this.lvSinhVien.Items.Count - 1;
			for (i = count; i >= 0; i--) 
			{
				lvitem = this.lvSinhVien.Items[i];
				if (lvitem.Checked)
					qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
			}
			this.LoadListView();
		}

		private void tsmiLoad_Click(object sender, EventArgs e)
		{
			qlsv.DsSinhVien.Clear();
			qlsv.DocFile();
			this.LoadListView();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (check)
			{
				DialogResult dlg = MessageBox.Show("Bạn có muốn lưu danh sách đã thay đổi hay không?", "Thông báo",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dlg == DialogResult.Yes)
				{
					this.qlsv.Luu(qlsv.DsSinhVien);
				}
				else if (dlg == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}
	}
}
