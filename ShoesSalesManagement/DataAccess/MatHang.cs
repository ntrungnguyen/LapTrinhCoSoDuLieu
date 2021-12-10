using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MatHang
    {
        public int ID { get; set; }
        public string TenMatHang { get; set; }
        public int ID_Loai { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public string ThuongHieu { get; set; }
        public byte[] HinhAnh { get; set; }
        public string MoTa { get; set; }
    }
}
