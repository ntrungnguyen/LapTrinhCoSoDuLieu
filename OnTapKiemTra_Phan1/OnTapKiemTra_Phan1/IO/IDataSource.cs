using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra_Phan1.IO
{
	public interface IDataSource
	{
		List<Khoa> DSKhoa();
		void Save(List<Khoa> khoa);
	}
}
