using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra_Phan1
{
	public class Lop
	{
		public string TenLop { get; set; }
		public List<SinhVien> DSSinhVien;

		public Lop(string tenlop)
		{
			this.TenLop = tenlop;
			DSSinhVien = new List<SinhVien>();
		}

		public void XoaSVLop(string mssv)
		{
			DSSinhVien.RemoveAll(x => x.MSSV == mssv);
		}
	}
}
