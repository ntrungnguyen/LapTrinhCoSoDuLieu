using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HoaDonDA
    {
        public List<HoaDon> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.HoaDon_GetAll;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<HoaDon> dsHoaDon = new List<HoaDon>();

            while (reader.Read())
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.ID = Convert.ToInt32(reader["ID"]);
                hoaDon.NgayBanHang = Convert.ToDateTime(reader["NgayBanHang"]);
                hoaDon.TenKhachHang = reader["TenKhachHang"].ToString();
                hoaDon.SoDienThoai = reader["SoDienThoai"].ToString();
                hoaDon.ID_NhanVien = Convert.ToInt32(reader["ID_NhanVien"]);
                hoaDon.KhuyenMai = Convert.ToInt32(reader["KhuyenMai"]);

                dsHoaDon.Add(hoaDon);
            }
            conn.Close();
            return dsHoaDon;
        }
    }
}
