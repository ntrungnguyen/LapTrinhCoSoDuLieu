using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_demo
{
	public class SinhVien
	{
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string Lop { get; set; }
		public string Hinh { get; set; }
		public bool GioiTinh { get; set; }
		public List<String> ChuyenNganh { get; set; }
		public SinhVien()
		{
			ChuyenNganh = new List<string>();
		}
		public SinhVien (string ms, string ht, DateTime ngay, string dc, string lop, string hinh,
			bool gt, List<String>cn)
		{
			this.MaSo = ms;
			this.HoTen = ht;
			this.NgaySinh = ngay;
			this.DiaChi = dc;
			this.Lop = lop;
			this.Hinh = Hinh;
			this.GioiTinh = gt;
			this.ChuyenNganh = cn;
		}
	}
}
