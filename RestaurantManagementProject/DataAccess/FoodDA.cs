using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //lớp quản lý Food: DA
    public class FoodDA
    {
        //phương thức lấy hết dữ liệu theo thủ tục food_getall
        public List<Food> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Food_GetAll;

            SqlDataReader reader = command.ExecuteReader();
            List<Food> list = new List<Food>();

            while (reader.Read())
            {
                Food food = new Food();
                food.ID = Convert.ToInt32(reader["ID"]);
                food.Name = reader["Name"].ToString();
                food.Unit = reader["Unit"].ToString();
                food.FoodCategoryID = Convert.ToInt32(reader["FoodCategoryID"]);
                food.Price = Convert.ToInt32(reader["Price"]);
                food.Notes = reader["Notes"].ToString();
                list.Add(food);
            }
            sqlConnection.Close();
            return list;
        }

        //phương thức thêm, xóa, sửa theo thủ tục food_insertupdatedelete
        public int Insert_Update_Delete(Food food, int action)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Food_InsertUpdateDelete;

            //thêm các tham số cho thủ tục, các tham số này chính là các tham số trong thủ tục
            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xóa, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = food.ID;

            //các biến còn lại chỉ truyền vào
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
            command.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = food.Unit;
            command.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
            command.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();

            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    } 
}
