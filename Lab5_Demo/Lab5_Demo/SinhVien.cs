using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Demo
{
	public class SinhVien
	{
		public string MSSV { get; set; }
		public string HoTenLot { get; set; }
		public DateTime NgaySinh { get; set; }
		public string CMND { get; set; }
		public string DiaChi { get; set; }
		public bool GioiTinh { get; set; }
		public string Ten { get; set; } 
		public string Lop { get; set; }
		public string SDT { get; set; }
		public List<String> MonHoc { get; set; }
		public SinhVien()
		{
			MonHoc = new List<string>();
		}

		public SinhVien (string mssv, string htl, DateTime ns, string cmnd, string dc,
			bool gt, string ten, string lop, string sdt, List<string> monhoc)
		{
			this.MSSV = mssv;
			this.HoTenLot = htl;
			this.NgaySinh = ns;
			this.CMND = cmnd;
			this.DiaChi = dc;
			this.GioiTinh = gt;
			this.Ten = ten;
			this.Lop = lop;
			this.SDT = sdt;
			this.MonHoc = monhoc;
		}
	}
}
