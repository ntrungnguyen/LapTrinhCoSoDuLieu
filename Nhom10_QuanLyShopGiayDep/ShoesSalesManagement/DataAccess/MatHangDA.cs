using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MatHangDA
    {
        public List<MatHang> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.MatHang_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<MatHang> listMH = new List<MatHang>();
            while (reader.Read())
            {
                MatHang matHang = new MatHang();
                matHang.ID = Convert.ToInt32(reader["ID"]);
                matHang.TenMatHang = reader["TenMatHang"].ToString();
                matHang.ID_Loai = Convert.ToInt32(reader["ID_Loai"]);
                matHang.SoLuong = Convert.ToInt32(reader["SoLuongTon"]);
                matHang.GiaNhap = Convert.ToInt32(reader["GiaNhap"]);
                matHang.GiaBan = Convert.ToInt32(reader["GiaBan"]);
                matHang.ThuongHieu = reader["ThuongHieu"].ToString();
                matHang.MoTa = reader["MoTa"].ToString();
                if (reader["HinhAnh"] is DBNull)
                {
                    matHang.HinhAnh = null;
                }
                else
                {
                    matHang.HinhAnh = (byte[])reader["HinhAnh"];
                }
                listMH.Add(matHang);
            }
            sqlConnection.Close();
            return listMH;
        }

        public int Insert_Update_Delete(MatHang matHang, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.MatHang_InsertUpdateDelete;

            SqlParameter parameter = new SqlParameter("@ID", SqlDbType.Int);
            parameter.Direction = ParameterDirection.InputOutput;

            cmd.Parameters.Add(parameter).Value = matHang.ID;
            cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar, 1000).Value = matHang.TenMatHang;
            cmd.Parameters.Add("@ID_Loai", SqlDbType.Int).Value = matHang.ID_Loai;
            cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = matHang.SoLuong;
            cmd.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = matHang.GiaNhap;
            cmd.Parameters.Add("@GiaBan", SqlDbType.Int).Value = matHang.GiaBan;
            cmd.Parameters.Add("@ThuongHieu", SqlDbType.NVarChar, 1000).Value = matHang.ThuongHieu;
            cmd.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = matHang.HinhAnh;
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 3000).Value = matHang.MoTa;

            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return (int)cmd.Parameters["@ID"].Value;

            return 0;
        }
    }
}
