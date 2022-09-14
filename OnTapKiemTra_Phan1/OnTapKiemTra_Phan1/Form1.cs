using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OnTapKiemTra_Phan1.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapKiemTra_Phan1
{
	public partial class FormQuanLy : Form
	{
		TreeNode node;
		public List<SinhVien> DSSinhVien;
		public List<Lop> lops;
		QuanLySinhVien qlsv;
		public SinhVien sv;
		private const string _hienthithongtin = "Nhập thông tin cần tìm !!!!!!!!!";

		public FormQuanLy(QuanLySinhVien qlsv)
		{
			this.qlsv = qlsv;
			InitializeComponent();
		}

		private void FormQuanLy_Load(object sender, EventArgs e)
		{
			LoadListView(qlsv.DSKhoa[0].DSSinhVien);
			LoadDSTreeView(qlsv.DSKhoa);
			HienThongTin();
		}

		
		private void LoadListView(List<SinhVien> DSSinhVien)
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sinhVien in DSSinhVien)
			{
				ThemSV(sinhVien);
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
			lvitem.SubItems.Add(sv.SDT);
			lvitem.SubItems.Add(sv.Lop);			
			lvitem.SubItems.Add(sv.Khoa);
			lvitem.SubItems.Add(sv.DiaChi);

			this.lvSinhVien.Items.Add(lvitem);
		}

		//Lấy thông tin từ LV
		private SinhVien GetSVListView(ListViewItem lvitem)
		{
			SinhVien sinhVien = new SinhVien();
			sv.MSSV = lvitem.SubItems[0].Text;
			sv.HoTenLot = lvitem.SubItems[1].Text;
			sv.Ten = lvitem.SubItems[2].Text;
			sv.GioiTinh = false;
			if (lvitem.SubItems[3].Text == "Nam")
				sv.GioiTinh = true;
			sv.NgaySinh = DateTime.Parse(lvitem.SubItems[4].Text);
			sv.Lop = lvitem.SubItems[5].Text;
			sv.SDT = lvitem.SubItems[6].Text;

			return sinhVien;
		}

		//Load treeview
		private void LoadDSTreeView(List<Khoa> dsKhoa)
		{
			foreach (Khoa khoa in dsKhoa)
			{
				var node = tvKhoa.Nodes.Add(khoa.TenKhoa);
				foreach (Lop lop in khoa.DSLop)
				{
					node.Nodes.Add(lop.TenLop);
				}
			}
			tvKhoa.ExpandAll();
		}

		//Đọc treeview
		private List<SinhVien> LoadListParent()
		{
			if(node.Level == 0)
			{
				int x = qlsv.DSKhoa.FindIndex(p => p.TenKhoa == node.Text);
				DSSinhVien = qlsv.DSKhoa[x].DSSinhVien;
			}
			else
			{
				int x = qlsv.DSKhoa.FindIndex(p => p.TenKhoa == node.Parent.Text);
				int y = qlsv.DSKhoa[x].DSLop.FindIndex(p => p.TenLop == node.Text);
				DSSinhVien = qlsv.DSKhoa[x].DSLop[y].DSSinhVien;
			}

			return DSSinhVien;
		}

		private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
		{
			node = e.Node;
			LoadListView(LoadListParent());
		}

		//Hiển thị thanh tìm kiếm
		private void HienThongTin()
		{
			tbTim.Text = _hienthithongtin;
			tbTim.GotFocus += XoaThongTin;
			tbTim.LostFocus += HienThongTin;
		}
		private void HienThongTin(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbTim.Text))
				tbTim.Text = _hienthithongtin;
		}

		private void XoaThongTin(object sender, EventArgs e)
		{
			if (tbTim.Text == _hienthithongtin)
				tbTim.Text = "";
		}

		//Tìm thông tin sinh viên
		private void tbTim_TextChanged(object sender, EventArgs e)
		{
			if (rdMSSV.Checked)
			{
				var sv = LoadListParent().FindAll(x => x.MSSV.Trim().ToLower().Contains(tbTim.Text));
				LoadListView(sv);
			}
			else if(rdHoTen.Checked)
			{
				var sv = LoadListParent().FindAll(x => x.Ten.Trim().ToLower().Contains(tbTim.Text));
				LoadListView(sv);
			}
			else if(rdSDT.Checked)
			{
				var sv = LoadListParent().FindAll(x => x.SDT.Trim().ToLower().Contains(tbTim.Text));
				LoadListView(sv);
			}
		}
		public int ViTriKhoa()
		{
			if (node.Level == 0)
			{
				return qlsv.DSKhoa.FindIndex(x => x.TenKhoa == node.Text);
			}
			else
			{
				return qlsv.DSKhoa.FindIndex(x => x.TenKhoa == node.Parent.Text);
			}
		}


		//Sự kiện xóa
		private void tsmiXoa_Click(object sender, EventArgs e)
		{
			int count, i;
			ListViewItem lvitem;
			count = lvSinhVien.Items.Count - 1;
			for (i = count; i >= 0; i--) 
			{
				lvitem = lvSinhVien.Items[i];
				if(lvitem.Selected)
				{
					qlsv.DSKhoa[ViTriKhoa()].Xoa(lvitem.SubItems[0].Text);
				}
			}
			MessageBox.Show("Bạn có chắc chắn muốn xóa hay không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
			LoadListView(LoadListParent());
		}

		//Sự kiện thêm sinh viên
		private void tsmiThem_Click(object sender, EventArgs e)
		{
			frmThemSV themsv = new frmThemSV(qlsv);
			themsv.ShowDialog();
			if (themsv.DialogResult == DialogResult.OK)
			{
				LoadListView(themsv.qlsv.DSKhoa[ViTriKhoa()].DSSinhVien);
			}
		}


		//Click đôi mở form thêm(Lưu)
		private void lvSinhVien_DoubleClick(object sender, EventArgs e)
		{
			frmThemSV themSV = new frmThemSV(qlsv);
			string item = lvSinhVien.SelectedItems[0].Text;
			SinhVien sinhVien = qlsv.DSKhoa[ViTriKhoa()].Tim(item);
			themSV.ThietLapSinhVien(sinhVien);
			themSV.ShowDialog();
			LoadListView(qlsv.DSKhoa[ViTriKhoa()].DSSinhVien);
		}


		//Lưu file excel, js
		private void excelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog LuuFileEx = new SaveFileDialog()
			{ Filter = "Excel Workbook (.xls) (.xlsx)|*.xls||*.xlsx", ValidateNames = true, InitialDirectory = "D:\\", FileName = node.Text, Title = "Quản lý sinh viên" }) 
				if (LuuFileEx.ShowDialog() == DialogResult.OK)
				{
					Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
					Workbook workbook = application.Workbooks.Add(XlSheetType.xlWorksheet);
					Worksheet worksheet = (Worksheet)application.ActiveSheet;
					application.Visible = true;
					int i = 1;
					int j = 1;

					foreach (ListViewItem item in lvSinhVien.Items)
					{
						worksheet.Cells[1, 1] = "MSSV";
						worksheet.Cells[1, 2] = "Họ tên lót";
						worksheet.Cells[1, 3] = "Tên";
						worksheet.Cells[1, 4] = "Giới tính";
						worksheet.Cells[1, 5] = "Ngày sinh";
						worksheet.Cells[1, 6] = "SDT";
						worksheet.Cells[1, 7] = "Lớp";
						worksheet.Cells[1, 8] = "Khoa";

						worksheet.Cells[i, j] = item.Text.ToString();
						foreach (ListViewItem.ListViewSubItem item1 in item.SubItems)
						{
							worksheet.Cells[i, j] = item1.Text.ToString();
							j++;
						}
						j = 1;
						i++;
					}
					workbook.SaveAs(LuuFileEx.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange,
						Type.Missing, Type.Missing);
					MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
		}
		private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog LuuFileJS = new SaveFileDialog() { Filter = "Json File (.json)|*.json", InitialDirectory = "D:\\", FileName = node.Text })
			{
				if (LuuFileJS.ShowDialog() == DialogResult.OK)
				{
					qlsv.LuuFileJs(LoadListParent(), LuuFileJS.FileName);
					MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
