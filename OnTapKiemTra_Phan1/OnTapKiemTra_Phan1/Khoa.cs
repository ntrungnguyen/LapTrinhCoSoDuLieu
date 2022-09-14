using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra_Phan1
{
	public class Khoa
	{
		public List<SinhVien> DSSinhVien;
		public List<Lop> DSLop;
		public string TenKhoa { get; set; }
		public Khoa(string tenkhoa)
		{
			DSSinhVien = new List<SinhVien>();
			DSLop = new List<Lop>();
			this.TenKhoa = tenkhoa;
		}

		public void Them(SinhVien sv)
		{
			int VTLop = DSLop.FindIndex(x => x.TenLop == sv.Lop);
			if (VTLop == -1)
			{
				Lop lop = new Lop(sv.Lop);
				lop.DSSinhVien.Add(sv);
				DSLop.Add(lop);
			}
			else
			{
				DSLop[VTLop].DSSinhVien.Add(sv);
			}
			DSSinhVien.Add(sv);
		}

		public void Xoa(string mssv)
		{
			SinhVien sv = DSSinhVien.Find(x => x.MSSV == mssv);
			DSSinhVien.Remove(sv);
			DSLop[TimViTriLop(sv.Lop)].XoaSVLop(mssv);
		}

		public SinhVien Tim(string mssv)
		{
			return DSSinhVien.Find(x => x.MSSV == mssv);
		}

		public void Sua(SinhVien sv)
		{
			int sinhvien = DSSinhVien.FindIndex(x => x.MSSV == sv.MSSV);
			if (sinhvien >= 0) 
			{
				DSSinhVien[sinhvien] = sv;
			}
		}

		public int TimViTriLop(string tenlop)
		{
			return DSLop.FindIndex(x => x.TenLop == tenlop);
		}
	}
}
