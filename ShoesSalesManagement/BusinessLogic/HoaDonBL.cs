using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class HoaDonBL
    {
        HoaDonDA hoaDonDA = new HoaDonDA();

        public List<HoaDon> GetAll()
        {
            return hoaDonDA.GetAll();
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
