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
	public partial class frmThemSV : Form
	{
		public QuanLySinhVien qlsv;
		public SinhVien sv;

		public bool sua;
		public frmThemSV(QuanLySinhVien qlsv)
		{
			InitializeComponent();
			this.qlsv = qlsv;
		}

		private void LoadLop(int vt)
		{
			cbbLop.Items.Clear();
			foreach (var sv in qlsv.DSKhoa[vt].DSLop)
			{
				cbbLop.Items.Add(sv.TenLop);
			}
		}

		private SinhVien GetSinhVien()
		{
			SinhVien sinhVien = new SinhVien();
			sinhVien.MSSV = this.mtbMSSV.Text;
			sinhVien.HoTenLot = this.tbHoTenLot.Text;
			sinhVien.Ten = this.tbTen.Text;
			bool gt = true;
			if (rdNu.Checked == true)		
				gt = false;
			sinhVien.GioiTinh = gt;
			sinhVien.NgaySinh = this.dtpNgaySinh.Value;
			sinhVien.Lop = this.cbbLop.Text;
			sinhVien.SDT = this.mtbSDT.Text;
			sinhVien.Khoa = this.cbbKhoa.Text;
			sinhVien.DiaChi = this.tbDiaChi.Text;
			return sinhVien;
		}

		public void ThietLapSinhVien(SinhVien sv)
		{
			this.mtbMSSV.Text = sv.MSSV;
			this.mtbMSSV.ReadOnly = true;
			this.tbHoTenLot.Text = sv.HoTenLot;
			this.tbTen.Text = sv.Ten;
			this.rdNam.Checked = true;
			if (sv.GioiTinh)	
				this.rdNam.Checked = true;	
			else
				this.rdNu.Checked = true;
			this.dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
			this.cbbLop.Text = sv.Lop;
			this.mtbSDT.Text = sv.SDT;
			this.cbbKhoa.Text = sv.Khoa;
			this.tbDiaChi.Text = sv.DiaChi;		
		}

		private void btnLuu_Click_1(object sender, EventArgs e)
		{
			if (mtbMSSV.Text == "" || tbHoTenLot.Text == "" || tbTen.Text == "" || cbbKhoa.Text == "" || cbbLop.Text == "")
			{
				MessageBox.Show("Yêu cầu nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (!sua)
			{
				SinhVien sv = GetSinhVien();
				this.qlsv.Them(sv);
				Close();
			}
			else
			{
				sv = GetSinhVien();
				this.qlsv.Sua(sv);
				Close();
			}
		}
	}
}
