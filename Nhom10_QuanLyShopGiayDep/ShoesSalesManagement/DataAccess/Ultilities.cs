using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  class Ultilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;

        public static string MatHang_GetAll = "MatHang_GetAll";
        public static string LoaiHang_GetAll = "LoaiHang_GetAll";
        public static string HoaDon_GetAll = "HoaDon_GetAll";
        public static string NguoiDung_GetAll = "NguoiDung_GetAll";
        public static string ChiTietHoaDon_GetAll = "ChiTietHoaDon_GetAll";


        public static string LoaiHang_InsertUpdateDelete = "LoaiHang_InsertUpdateDelete";
        public static string MatHang_InsertUpdateDelete = "MatHang_InsertUpdateDelete";
        public static string HoaDon_InsertUpdateDelete = "HoaDon_InsertUpdateDelete";
        public static string ChiTietHoaDon_InsertUpdateDelete = "ChiTietHoaDon_InsertUpdateDelete";

        public static string Loai_GetIDCha = "LoaiHang_GetIDCha";
        public static string Loai_GetIDCon = "LoaiHang_GetIDCon";
    }
}
