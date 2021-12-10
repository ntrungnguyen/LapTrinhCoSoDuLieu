using DataAccess;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class MatHangBL
    {
        MatHangDA matHangDA = new MatHangDA();
        public List<MatHang> GetAll()
        {
            return matHangDA.GetAll();
        }

        public List<MatHang> Search(string key)
        {
            List<MatHang> list = GetAll();
            List<MatHang> result = new List<MatHang>();

            foreach (var item in list)
            {
                if (item.GiaBan.ToString().Contains(key)
                    || item.ID.ToString().Contains(key)
                    || item.TenMatHang.Contains(key)
                    || item.SoLuong.ToString().Contains(key)
                    || item.ThuongHieu.Contains(key)
                    || item.GiaBan.ToString().Contains(key))
                    result.Add(item);
            }
            return result;
        }

        public int Insert(MatHang matHang)
        {
            return matHangDA.Insert_Update_Delete(matHang, 0);
        }
        public int Update(MatHang matHang)
        {
            return matHangDA.Insert_Update_Delete(matHang, 1);
        }
        public int Delete(MatHang matHang)
        {
            return matHangDA.Insert_Update_Delete(matHang, 2);
        }
    }
}
