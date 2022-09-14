using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LoaiHangBL
    {
        LoaiHangDA loaiHangDA = new LoaiHangDA();
        public List<LoaiHang> GetAll()
        {
            return loaiHangDA.GetAll();
        }

        public int Insert(LoaiHang loai)
        {
            return loaiHangDA.Insert_Update_Delete(loai, 0);
        }
        public int Update(LoaiHang loai)
        {
            return loaiHangDA.Insert_Update_Delete(loai, 1);
        }
        public int Delete(LoaiHang loai)
        {
            return loaiHangDA.Insert_Update_Delete(loai, 2);
        }

        public List<LoaiHang> GetIDCha()
        {
            return loaiHangDA.GetIDCha();
        }
        public List<LoaiHang> GetIDCon()
        {
            return loaiHangDA.GetIDCon();
        }
    }
}
