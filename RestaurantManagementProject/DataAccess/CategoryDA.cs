using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDA
    {
        public List<Category> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Category_GetAll;

            //đọc dữ liệu, trả về danh sách các đối tượng Category
            SqlDataReader reader = cmd.ExecuteReader();
            List<Category> list = new List<Category>();

            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                list.Add(category);
            }
            sqlConnection.Close();
            return list;
        }


        //phương thức thêm, xóa, sửa theo thủ tục category_InsertUpdateDelete
        public int Insert_Update_Delete(Category category, int action)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_InsertUpdateDelete;

            //Thêm các tham số cho thủ tục, các tham số này chính là các tham số trong thủ tục
            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xóa, sửa

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; //vừa vào vừa ra
            command.Parameters.Add(IDPara).Value = category.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = category.Name;
            command.Parameters.Add("@Type", SqlDbType.Int).Value = category.Type;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            //thực thi lệnh
            int result = command.ExecuteNonQuery();
            if (result > 0)     //nếu thành công thì trả về ID đã thêm
                return (int)command.Parameters["@ID"].Value;

            return 0;
        }

       
    }
}
