using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ChiTietHoaDonBL
    {
        ChiTietHoaDonDA chiTietHoaDonDA = new ChiTietHoaDonDA();

        public List<ChiTietHoaDon> GetAll()
        {
            return chiTietHoaDonDA.GetAll();
        }
    }
}
