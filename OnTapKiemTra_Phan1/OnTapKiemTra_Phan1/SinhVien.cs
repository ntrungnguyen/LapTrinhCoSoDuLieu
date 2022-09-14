using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra_Phan1
{
	public class SinhVien
	{
		public string MSSV { get; set; }
		public string HoTenLot { get; set; }
		public string Ten { get; set; }
		public bool GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public string SDT { get; set; }
		public string Khoa { get; set; }
		public string DiaChi { get; set; }
		public SinhVien (string mssv, string hotenlot, string ten, bool gioitinh,
			DateTime ngaysinh, string lop, string sdt, string khoa, string diachi)
		{
			this.MSSV = mssv;
			this.HoTenLot = hotenlot;
			this.Ten = ten;
			this.GioiTinh = gioitinh;
			this.NgaySinh = ngaysinh;
			this.Lop = lop;
			this.SDT = sdt;
			this.Khoa = khoa;
			this.DiaChi = diachi;
		}

		public SinhVien()
		{

		}
	}
}
