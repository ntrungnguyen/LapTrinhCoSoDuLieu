using Lab5_Demo.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Demo
{
	public delegate int SoSanh(Object sv1, object sv2);
	public class QuanLySinhVien
	{
		public List<SinhVien> DSSinhVien;
		private IDataSource _dataSource;
		public QuanLySinhVien()
		{
			DSSinhVien = new List<SinhVien>();
			_dataSource = new TextDataSource();
			DSSinhVien = _dataSource.GetSinhViens();
		}
		public SinhVien this[int index]
		{
			get { return DSSinhVien[index]; }
			set { DSSinhVien[index] = value; }
		}

		//Chức năng
		public void Them(SinhVien sv)
		{
			DSSinhVien.Add(sv);
		}
		public SinhVien Tim(object obj, SoSanh ss)
		{
			SinhVien kq = null;
			foreach (SinhVien sv in DSSinhVien)
			{
				if (ss(obj, sv) == 0)
				{
					kq = sv;
					break;
				}
			}
			return kq;
		}
		public void Xoa(string mssv)
		{
			for (int i = this.DSSinhVien.Count - 1; i >= 0; i--) 
			{
				if (DSSinhVien[i].MSSV == mssv)
					this.DSSinhVien.RemoveAt(i);
			}			
		}
		public void Sua(SinhVien svsua)
		{
			var kq = DSSinhVien.Find(p => p.MSSV == svsua.MSSV);
			if (kq == null)
			{
				return;
			}
			else
			{
				DSSinhVien.RemoveAll(p => p.MSSV == svsua.MSSV);
				DSSinhVien.Add(svsua);
			}
		}
		public void Luu()
		{
			_dataSource.Save(DSSinhVien);
		}

		public List<SinhVien> GetSinhViens()
		{
			if (DSSinhVien == null)
			{
				DSSinhVien = _dataSource.GetSinhViens();

			}
			return DSSinhVien;
		}
	}
}
