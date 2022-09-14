using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NguoiDungDA
    {
        public List<NguoiDung> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.NguoiDung_GetAll;

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<NguoiDung> listNguoiDung = new List<NguoiDung>();

            while (reader.Read())
            {
                NguoiDung nguoiDung = new NguoiDung();
                nguoiDung.ID = Convert.ToInt32(reader["ID"]);
                nguoiDung.TenNhanVien = reader["TenNhanVien"].ToString();
                nguoiDung.SoDienThoai = reader["SoDienThoai"].ToString();
                nguoiDung.DiaChi = reader["DiaChi"].ToString();
                nguoiDung.TaiKhoan = reader["TaiKhoan"].ToString();
                nguoiDung.MatKhau = reader["MatKhau"].ToString();
                nguoiDung.TrangThai = bool.Parse(reader["TrangThai"].ToString());

                listNguoiDung.Add(nguoiDung);
            }

            return listNguoiDung;
        }
    }
}
