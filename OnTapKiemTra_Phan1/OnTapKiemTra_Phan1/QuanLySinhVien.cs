using OnTapKiemTra_Phan1.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra_Phan1
{
	public class QuanLySinhVien
	{
		public IDataSource _dataSource;
		public List<Khoa> DSKhoa;

		public QuanLySinhVien()
		{
		}

		public QuanLySinhVien(IDataSource dataSource)
		{
			this._dataSource = dataSource;
			DSKhoa = _dataSource.DSKhoa();
		}

		public Khoa this[int index]
		{
			get { return DSKhoa[index]; }
			set { DSKhoa[index] = value; }
		}

		public void Them(SinhVien sv)
		{
			Khoa khoa = DSKhoa.Find(x => x.TenKhoa == sv.Khoa);
			if (khoa != null)
			{
				khoa.Them(sv);
			}
		}

		public void Sua(SinhVien sv)
		{
			Khoa khoa = DSKhoa.Find(x => x.TenKhoa == sv.Khoa);
			if (khoa != null)
			{
				khoa.Sua(sv);
			}
		}

		public void LuuFileJs(List<SinhVien> sv, string _filePath)
		{
			IClass dataLop = new JsonDataSource();
			dataLop.Save(sv, _filePath);

		}
	}
}
