using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_demo
{
	public partial class frmSinhVien : Form
	{
		QuanLySinhVien qlsv;
		public frmSinhVien()
		{
			InitializeComponent();
		}

		// Lấy thông tin từ control 
		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			List<string> cn = new List<string>();
			sv.MaSo = this.mtxtMaSo.Text;
			sv.HoTen = this.txtHoTen.Text;
			sv.NgaySinh = this.dtpNgaySinh.Value;
			sv.DiaChi = this.txtDiaChi.Text;
			sv.Lop = this.cboLop.Text;
			sv.Hinh = this.txtHinh.Text;
			if (rdNu.Checked)
				gt = false;
			sv.GioiTinh = gt;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
				if (clbChuyenNganh.GetItemChecked(i))
					cn.Add(clbChuyenNganh.Items[i].ToString());
			sv.ChuyenNganh = cn;
			return sv;
		}
		
		// Lấy thông tin từ ListView
		private SinhVien GetSinhVienLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = lvitem.SubItems[0].Text;
			sv.HoTen = lvitem.SubItems[1].Text;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
			sv.DiaChi = lvitem.SubItems[3].Text;
			sv.Lop = lvitem.SubItems[4].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[5].Text == "Nam")
				sv.GioiTinh = true;
			List<string> cn = new List<string>();
			string[] s = lvitem.SubItems[6].Text.Split(',');
			foreach (string t in s)
				cn.Add(t);
				sv.ChuyenNganh = cn;
			sv.Hinh = lvitem.SubItems[7].Text;
			return sv;
		}

		//Thiết lập các thông tin lên controls sinh viên
		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtxtMaSo.Text = sv.MaSo;
			this.txtHoTen.Text = sv.HoTen;
			this.dtpNgaySinh.Value = sv.NgaySinh;
			this.txtDiaChi.Text = sv.DiaChi;
			this.cboLop.Text = sv.Lop;
			this.txtHinh.Text = sv.Hinh;
			this.pbHinh.ImageLocation = sv.Hinh;
			if (sv.GioiTinh)
				this.rdNam.Checked = true;
			else
				this.rdNu.Checked = true;

			for (int i = 0; i < clbChuyenNganh.Items.Count; i++)
				this.clbChuyenNganh.SetItemChecked(i, false);

			foreach (string s in sv.ChuyenNganh)
			{
				for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
					if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
						this.clbChuyenNganh.SetItemChecked(i, true);
			}
		}

		// Thêm sinh viên vào ListView
		private void ThemSV(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MaSo);
			lvitem.SubItems.Add(sv.HoTen);
			lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Lop);
			string gt = "Nữ";
			if (sv.GioiTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);

			string cn = "";
			foreach (string s in sv.ChuyenNganh)
				cn += s + ",";
			lvitem.SubItems.Add(cn);
			if (string.IsNullOrEmpty(cn))
			{
				MessageBox.Show("Vui lòng điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}

		//Hiển thị các sinh viên trong qlsv lên ListView
		private void LoadListView()
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in qlsv.DanhSach)
			{
				ThemSV(sv);
			}
			tsslTongSV.Text = "Tổng sinh viên: " + lvSinhVien.Items.Count;
		}


		//Load form
		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			qlsv = new QuanLySinhVien();
			qlsv.DocTuFile();
			LoadListView();
		}

		//Click ListView gán thông tin lên control
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

		private void btnThem_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
			});
			if (kq != null)
			{
				MessageBox.Show("Mã sinh viên đã tồn tại", "Lỗi thêm dữ liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.qlsv.Them(sv);
				this.LoadListView();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnXoa_Click(object sender, EventArgs e)
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
			this.btnMacDinh.PerformClick();
		}

		private int SoSanhTheoMa(object obj1, object obj2)
		{
			SinhVien sv = obj2 as SinhVien;
			return sv.MaSo.CompareTo(obj1);
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			this.mtxtMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.dtpNgaySinh.Value = DateTime.Now;
			this.txtDiaChi.Text = "";
			this.cboLop.Text = this.cboLop.Items[0].ToString();
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";
			this.rdNam.Checked = true;
			for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
				this.clbChuyenNganh.SetItemChecked(i, false);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			bool kqsua;
			kqsua = qlsv.Sua(sv, sv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
			});
			this.LoadListView();			
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Select Picture";// "Add Photos";
			dlg.Filter = "Image Files (*.bmp; *.jpg; *.png.)|";

			dlg.InitialDirectory = Environment.CurrentDirectory;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				var filename = dlg.FileName;
				txtHinh.Text = filename;
				pbHinh.Load(filename);
			}

		}

		private void mnsExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		// Bài tập

		private void mnsOpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Select Picture";// "Add Photos";
			dlg.Filter = "Image Files (*.bmp; *.jpg; *.png.)|";

			dlg.InitialDirectory = Environment.CurrentDirectory;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				var filename = dlg.FileName;
				txtHinh.Text = filename;
				pbHinh.Load(filename);
			}
		}

		//Tạo hàm load 
		private void LoadListSV(List<SinhVien> danhsachSV)
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in danhsachSV)
			{
				ThemSV(sv);
			}
		}

		private void mnsSapXep_Click(object sender, EventArgs e)
		{
			frmTuyChon form = new frmTuyChon(qlsv, 0);
			form.ShowDialog();
			LoadListSV(form.dsSV);
		}

		private void mnsSearch_Click(object sender, EventArgs e)
		{
			frmTuyChon form = new frmTuyChon(qlsv, 1);
			form.ShowDialog();
			LoadListSV(form.dsSV);
		}

		private void mnsDelete_Click(object sender, EventArgs e)
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

		private void mnsAdd_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
			});
			if (kq != null)
			{
				MessageBox.Show("Mã sinh viên đã tồn tại", "Lỗi thêm dữ liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.qlsv.Them(sv);
				this.LoadListView();
			}
		}

		private void mnsEdit_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			bool kqsua;
			kqsua = qlsv.Sua(sv, sv.MaSo, delegate (object obj1, object obj2)
			{
				return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
			});
			this.LoadListView();
		}

		//Font chữ
		private void tsmiBold_Click(object sender, EventArgs e)
		{
			lvSinhVien.Font = new Font(lvSinhVien.Font, FontStyle.Bold);
		}

		private void tsmiItalic_Click(object sender, EventArgs e)
		{
			lvSinhVien.Font = new Font(lvSinhVien.Font, FontStyle.Italic);
		}

		private void tsmiUnderline_Click(object sender, EventArgs e)
		{
			lvSinhVien.Font = new Font(lvSinhVien.Font, FontStyle.Underline);
		}


		//Màu chữ
		private void tsmiRed_Click(object sender, EventArgs e)
		{
			lvSinhVien.ForeColor = Color.Red;
		}

		private void tsmiGreen_Click(object sender, EventArgs e)
		{
			lvSinhVien.ForeColor = Color.Green;
		}

		private void tsmiYellow_Click(object sender, EventArgs e)
		{
			lvSinhVien.ForeColor = Color.Yellow;
		}


		
	}

	
}
