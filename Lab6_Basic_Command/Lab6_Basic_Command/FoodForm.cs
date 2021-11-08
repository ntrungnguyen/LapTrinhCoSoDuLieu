using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab6_Basic_Command
{
	public partial class frmFood : Form
	{
		public int categoryID;
		public frmFood()
		{
			InitializeComponent();
		}

		public void LoadFood(int categoryID)
		{
			//tạo đối tượng kết nối
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh 
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//thiết lập lệnh truy vấn cho command
			sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;

			//Mở kết nối tới CSDL
			sqlConnection.Open();

			//gán tên nhóm sản phẩm cho tiêu đề
			//string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " /*+ catName*/;

			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			//Tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvFood.DataSource = dt;
			dgvFood.Columns[0].HeaderText = "ID";
			dgvFood.Columns[1].HeaderText = "Tên món ăn";
			dgvFood.Columns[2].HeaderText = "Đơn vị tính";
			dgvFood.Columns[3].HeaderText = "ID nhóm món ăn";
			dgvFood.Columns[4].HeaderText = "Đơn giá";
			dgvFood.Columns[5].HeaderText = "Ghi chú";

			//Hiển thị danh sách món ăn lên form
			dgvFood.DataSource = dt;

			//Đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string findID = dgvFood.CurrentRow.Cells[0].Value.ToString();

			sqlCommand.CommandText = $"DELETE FROM Food WHERE ID = {findID}";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				dgvFood.Rows.Remove(dgvFood.CurrentRow);
				MessageBox.Show("Xóa món ăn thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string[] cell = new string[6];
			cell[0] = dgvFood.CurrentRow.Cells[0].Value.ToString();
			cell[1] = dgvFood.CurrentRow.Cells[1].Value.ToString();
			cell[2] = dgvFood.CurrentRow.Cells[2].Value.ToString();
			cell[3] = dgvFood.CurrentRow.Cells[3].Value.ToString();
			cell[4] = dgvFood.CurrentRow.Cells[4].Value.ToString();
			cell[5] = dgvFood.CurrentRow.Cells[5].Value.ToString();
			if (cell[0] == "")
			{
				ThemMonAn(cell);
			}
			else
				CapNhatMonAn(cell);
			LoadFood(categoryID);
		}

		private void ThemMonAn(string[] cell)
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = $"INSERT INTO Food([Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (N'{cell[1]}', N'{cell[2]}', {categoryID}, N'{cell[4]}', N'{cell[5]}')";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm món ăn thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}
		private void CapNhatMonAn(string[] cell)
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = connection.CreateCommand();

			connection.Open();

			sqlCommand.CommandText = $"UPDATE Food SET Name=N'{cell[1]}', Unit=N'{cell[2]}', Price = {cell[4]}, Notes=N'{cell[5]}' where ID = {cell[0]}";

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			connection.Close();
			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Cập nhật món ăn thành công");

			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

	}
}
