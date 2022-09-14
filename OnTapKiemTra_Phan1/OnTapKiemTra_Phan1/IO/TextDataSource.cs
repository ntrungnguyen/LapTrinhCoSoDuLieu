using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra_Phan1.IO
{
	public class TextDataSource : IDataSource
	{
		public string _filePath; /*= "C:\\Users\\nguye\\OneDrive\\Máy tính\\OnTapKiemTra_Phan1\\OnTapKiemTra_Phan1\\bin\\Debug\\data.txt";*/
		public TextDataSource(string filepath)
		{
			this._filePath = filepath;
		}
		public List<Khoa> DSKhoa()
		{
			List<Khoa> dsKhoa = new List<Khoa>();
			//string FileName = "data.txt", t;
			//string[] s;
			
			if (File.Exists(_filePath))
			{
				using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
				{
					using (var reader = new StreamReader(stream))
					{
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							var sinhviens = ParseSV(line);
							
							//Tìm vị trí của Khoa
							int VTKhoa = dsKhoa.FindIndex(x => x.TenKhoa == sinhviens.Khoa);
							if(VTKhoa == -1)
							{
								Khoa khoa = new Khoa(sinhviens.Khoa); 
								khoa.Them(sinhviens); 
								dsKhoa.Add(khoa);
							}
							else
							{
								dsKhoa[VTKhoa].Them(sinhviens);
							}
						}
					}
				}
			}
			return dsKhoa;
		}

		public void Save(List<Khoa> khoa)
		{
			throw new NotImplementedException();
		}

		private SinhVien ParseSV(string line)
		{
			var parts = line.Split('\t');
			SinhVien sv = new SinhVien();

			sv.MSSV = parts[0];
			sv.HoTenLot = parts[1];
			sv.Ten = parts[2];
			sv.Lop = parts[3];
			sv.Khoa = parts[4];
			if (parts.Length > 5)
			{
				sv.GioiTinh = parts[5] == "Nam" ? true : false;
				sv.NgaySinh = DateTime.Parse(parts[6]);
				sv.SDT = parts[7];
				sv.DiaChi = parts[8];
			}
			return sv;
		}
	}
}
