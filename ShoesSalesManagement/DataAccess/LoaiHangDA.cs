using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LoaiHangDA
    {
        public List<LoaiHang> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.LoaiHang_GetAll;

            SqlDataReader reader = cmd.ExecuteReader();
            List<LoaiHang> list = new List<LoaiHang>();
            while (reader.Read())
            {
                LoaiHang loaiHang = new LoaiHang();
                loaiHang.ID = Convert.ToInt32(reader["ID"]);
                loaiHang.TenLoai = reader["TenLoai"].ToString();
                loaiHang.ID_Cha = Convert.ToInt32(reader["ID_Cha"]);
                loaiHang.MoTa = reader["MoTa"].ToString();
                list.Add(loaiHang);
            }
            sqlConnection.Close();
            return list;
        }


        public int Insert_Update_Delete(LoaiHang lh, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.LoaiHang_InsertUpdateDelete;

            SqlParameter parameter = new SqlParameter("@ID", SqlDbType.Int);
            parameter.Direction = ParameterDirection.InputOutput;

            cmd.Parameters.Add(parameter).Value = lh.ID;

            cmd.Parameters.Add("@TenLoai", SqlDbType.NVarChar, 1000).Value = lh.TenLoai;
            cmd.Parameters.Add("@ID_Cha", SqlDbType.Int).Value = lh.ID_Cha;
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar, 3000).Value = lh.MoTa;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                return (int)cmd.Parameters["@ID"].Value;
            }           

            return 0;
        }

        public List<LoaiHang> GetIDCha()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Loai_GetIDCha;


            SqlDataReader reader = cmd.ExecuteReader();
            List<LoaiHang> dsLoaiHang = new List<LoaiHang>();

            while (reader.Read())
            {
                LoaiHang loai = new LoaiHang();
                loai.ID = Convert.ToInt32(reader["ID"]);
                loai.TenLoai = reader["TenLoai"].ToString();
                loai.ID_Cha = Convert.ToInt32(reader["ID_Cha"].ToString() == "NULL" ? " " : reader["ID_Cha"].ToString());
                loai.MoTa = reader["MoTa"].ToString();

                dsLoaiHang.Add(loai);
            }
            conn.Close();
            return dsLoaiHang;            
        }

        public List<LoaiHang> GetIDCon()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Loai_GetIDCon;

            
            SqlDataReader reader = command.ExecuteReader();
            List<LoaiHang> list = new List<LoaiHang>();

            while (reader.Read())
            {
                LoaiHang loai = new LoaiHang();
                loai.ID = Convert.ToInt32(reader["ID"]);
                loai.TenLoai = reader["TenLoai"].ToString();
                loai.MoTa = reader["MoTa"].ToString();
                loai.ID_Cha = Convert.ToInt32(reader["ID_Cha"].ToString() == "NULL" ? " " : reader["ID_Cha"].ToString());

                list.Add(loai);
            }
            conn.Close();
            return list;
        }
    }
}
