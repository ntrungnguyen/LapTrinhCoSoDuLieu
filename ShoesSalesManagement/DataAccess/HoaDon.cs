using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HoaDon
    {
        public int ID { get; set; }
        public DateTime NgayBanHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public int ID_NhanVien { get; set; }
        public float KhuyenMai { get; set; }
    }
}
