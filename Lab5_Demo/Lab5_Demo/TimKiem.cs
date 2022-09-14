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
	public partial class TimKiem : Form
	{
		public List<SinhVien> dssv;
		public SinhVien sv;
		public TimKiem(QuanLySinhVien qlsv)
		{
			dssv = qlsv.DSSinhVien;
			InitializeComponent();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			var timkiem = tbTim.Text;
			if (rdMSSV.Checked == true)
			{
				SinhVien kq = dssv.Find(x => x.MSSV == timkiem.Trim());
				if (kq == null)
				{
					MessageBox.Show("Không tìm thấy sinh viên có mã: " + timkiem, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					Form1 form = new Form1();
				}
			}
		}
	}
}
