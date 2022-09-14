using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HoaDonBL
    {
        HoaDonDA HoaDonDA = new HoaDonDA();

        public List<HoaDon> GetAll()
        {
            return HoaDonDA.GetAll();
        }
        public List<HoaDon> Search(string key)
        {
            List<HoaDon> dsHoaDon = GetAll();
            List<HoaDon> result = new List<HoaDon>();

            foreach (var item in dsHoaDon)
            {
                if (item.TenKhachHang.ToString().Contains(key)
                    || item.SoDienThoai.Contains(key))
                    result.Add(item);
            }
            return result;
        }

    }
}
