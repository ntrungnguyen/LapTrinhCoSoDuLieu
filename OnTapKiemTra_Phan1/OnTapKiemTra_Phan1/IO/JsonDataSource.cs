using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace OnTapKiemTra_Phan1
{
	internal class JsonDataSource : IClass
	{
		public void Save(List<SinhVien> sv, string _filePath)
		{
			var data = JsonConvert.SerializeObject(sv);
			File.WriteAllText(_filePath, data);
		}
	}
}