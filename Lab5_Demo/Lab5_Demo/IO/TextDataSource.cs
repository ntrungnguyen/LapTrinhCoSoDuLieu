using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Demo.IO
{
	public class TextDataSource : IDataSource
	{
		private const string _filepath = "C:\\Users\\nguye\\OneDrive\\Máy tính\\Lab5_Demo\\Lab5_Demo\\bin\\Debug\\SinhVien.txt";
		public List<SinhVien> GetSinhViens()
		{
			List<SinhVien> sinhViens = new List<SinhVien>();
			string FileName = "SinhVien.txt", t;
			string[] s;
			SinhVien sv;
			using (var stream = new FileStream(FileName, FileMode.Open))
			{
				using (var reader = new StreamReader(stream))
				{
					while ((t = reader.ReadLine()) != null)
					{
						s = t.Split('*');
						sv = new SinhVien();
						sv.MSSV = s[0];
						sv.HoTenLot = s[1];
						sv.Ten = s[2];
						sv.GioiTinh = false;
						if (s[3] == "1")
							sv.GioiTinh = true;
						sv.NgaySinh = DateTime.Parse(s[4]);
						sv.Lop = s[5];
						sv.CMND = s[6];
						sv.SDT = s[7];
						sv.DiaChi = s[8];
						string[] mh = s[9].Split('\t');
						foreach (var item in mh)
						{
							sv.MonHoc.Add(item);
						}
						sinhViens.Add(sv);
					}
				}
			}
			return sinhViens;
		}

		public void Save(List<SinhVien> sinhvien)
		{
			using (var stream = new FileStream(_filepath, FileMode.Create, FileAccess.ReadWrite))
			{
				using (var writer = new StreamWriter(stream))
				{
					foreach (var sv in sinhvien)
					{
						writer.WriteLine("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}",
						sv.MSSV, sv.HoTenLot, sv.Ten, sv.GioiTinh ? 1 : 0, sv.NgaySinh, sv.Lop, sv.CMND, sv.SDT, sv.DiaChi, ParseMonHoc(sv.MonHoc));
					}
				}
			}
		}
		private string ParseMonHoc(List<string> monhoc)
		{
			string dsmh = "";
			foreach (var item in monhoc)
			{
				dsmh += item + ",";
			}

			return dsmh;
		}
	}
}
