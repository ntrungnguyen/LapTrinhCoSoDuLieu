using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ChiTietHoaDonDA
    {
        public List<ChiTietHoaDon> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.ChiTietHoaDon_GetAll;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<ChiTietHoaDon> dsChiTietHoaDon = new List<ChiTietHoaDon>();

            while (reader.Read())
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.ID = Convert.ToInt32(reader["ID"]);
                chiTietHoaDon.ID_HoaDon = Convert.ToInt32(reader["ID_HoaDon"]);
                chiTietHoaDon.ID_MatHang = Convert.ToInt32(reader["ID_MatHang"]);
                chiTietHoaDon.SoLuongMua = Convert.ToInt32(reader["SoLuongMua"]);

                dsChiTietHoaDon.Add(chiTietHoaDon);
            }
            conn.Close();
            return dsChiTietHoaDon;
        }
    }
}
