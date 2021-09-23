using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Demo
{
	public delegate int SoSanh(Object sv1, object sv2);
	public class QuanLySinhVien
	{
		public List<SinhVien> DsSinhVien;
		private const string _filePath = "SinhVien.txt";

		public QuanLySinhVien()
		{
			DsSinhVien = new List<SinhVien>();
		}
		public SinhVien this[int index]
		{
			get { return DsSinhVien[index]; }
			set { DsSinhVien[index] = value; }
		}
		public void Them(SinhVien sv)
		{
			this.DsSinhVien.Add(sv);
		}

		public SinhVien Tim(object obj, SoSanh ss)
		{
			SinhVien svresult = null;
			foreach (SinhVien sv in DsSinhVien)
			{
				if (ss(obj, sv) == 0)
				{
					svresult = sv;
					break;
				}
			}
			return svresult;
		}

		public void Xoa(object obj, SoSanh ss)
		{
			int i = DsSinhVien.Count - 1;
			for (; i >= 0; i--)
				if (ss(obj, this[i]) == 0)
					this.DsSinhVien.RemoveAt(i);			
		}

		public bool Sua(SinhVien svsua, object obj, SoSanh ss)
		{
			int i, count;
			bool kq = false;
			count = this.DsSinhVien.Count;
			for (i = 0; i < count; i++)
				if (ss(obj, this[i]) == 0)
				{
					this[i] = svsua;
					kq = true;
					break;
				}
			return kq;
		}

		public void DocFile()
		{
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
						sv.MaSo = s[0];
						sv.HoTen = s[1];
						sv.GioiTinh = false;
						if (s[2] == "1")
							sv.GioiTinh = true;
						sv.NgaySinh = DateTime.Parse(s[3]);
						sv.Lop = s[4];
						sv.SoDienThoai = s[5];
						sv.Email = s[6];
						sv.DiaChi = s[7];
						sv.Hinh = s[8];
						this.Them(sv);
					}
				}
			}			
		}

		public void Luu(List<SinhVien> dsSv)
		{
			using (var stream = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
			{
				using (var write = new StreamWriter(stream))
				{
					foreach (var sv in dsSv)
					{
						write.WriteLine("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*", sv.MaSo,
							 sv.HoTen, sv.GioiTinh == true ? "Nam" : "Nữ", sv.NgaySinh, sv.Lop, sv.SoDienThoai,
							 sv.Email, sv.DiaChi, sv.Hinh);
					}
				}
			}
		}
	}
}
