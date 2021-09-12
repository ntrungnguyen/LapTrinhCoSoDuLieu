using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Demo
{
	public delegate int SoSanh(object gv1, object gv2);
	public class QuanLyGiaoVien
	{
		public List<GiaoVien> dsGiaoVien;

		public QuanLyGiaoVien()
		{
			dsGiaoVien = new List<GiaoVien>();
		}
		public GiaoVien this[int index]
		{
			get { return dsGiaoVien[index]; }
			set { dsGiaoVien[index] = value; }
		}

		public void Add(GiaoVien gv)
		{
			this.dsGiaoVien.Add(gv);
		}

		public GiaoVien Tim(object obj1, SoSanh ss)
		{
			GiaoVien gvResult = null;
			foreach (GiaoVien gv in dsGiaoVien)
				if (ss(obj1, gv) == 0)
				{
					gvResult = gv;
					break;
				}
			return gvResult;
		}

		public void Xoa(object obj, SoSanh ss)
		{
			for (int i = dsGiaoVien.Count - 1; i >= 0; i--)
			{
				if (ss(obj, this[i]) == 0)
					this.dsGiaoVien.RemoveAt(i);
			}
		}
		enum KieuTim
		{
			TheoMa,
			TheoHoTen,
			TheoSDT
		}
	}
}
