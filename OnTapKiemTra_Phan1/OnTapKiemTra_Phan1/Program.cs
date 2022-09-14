using OnTapKiemTra_Phan1.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapKiemTra_Phan1
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			IDataSource dataSource = new TextDataSource(@"D:\Học\Năm 3\Học Kì 1\Lập Trình Cơ Sở Dữ Liệu\OnTapKiemTra_Phan1\OnTapKiemTra_Phan1\data.txt");
			QuanLySinhVien qlsv = new QuanLySinhVien(dataSource);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormQuanLy(qlsv));
		}
	}
}
