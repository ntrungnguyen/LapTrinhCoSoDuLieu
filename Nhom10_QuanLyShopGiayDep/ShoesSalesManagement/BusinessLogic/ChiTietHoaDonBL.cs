using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
