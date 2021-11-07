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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			//tạo chuỗi kết nối tới csdl
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";

			//tạo đối tượng kết nối
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//thiết lập lệnh truy vấn cho đối tượng command
			string query = "SELECT ID, NAME, Type FROM Category";
			sqlCommand.CommandText = query;

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương thức ExcuteReader
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			//Gọi hàm hiển thị dữ liệu lên màn hình
			this.DisplayCategory(sqlDataReader);

			//Đóng kết nối
			sqlConnection.Close();
		}

		private void DisplayCategory(SqlDataReader reader)
		{
			//xóa tất cả các dòng hiện tại
			lvCategory.Items.Clear();

			//đọc một dòng dữ liệu
			while (reader.Read())
			{
				//tạo một dòng mới trong listview
				ListViewItem item = new ListViewItem(reader["ID"].ToString());

				//thêm dòng mới vào listview
				lvCategory.Items.Add(item);

				//bổ sung các thông tin khác cho listviewitem
				item.SubItems.Add(reader["Name"].ToString());
				item.SubItems.Add(reader["Type"].ToString());
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn cho đối tượng Command
			sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" + "VALUES (N'" + txtCategoryName.Text + "', " + txtType.Text + ")";

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm nhóm món ăn thành công");
				//Tải lại dữ liệu
				btnLoad.PerformClick();

				//Xóa các ô nhập
				txtCategoryName.Text = "";
				txtType.Text = "";
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void lvCategory_Click(object sender, EventArgs e)
		{
			//Lấy dòng được chọn trong listview
			ListViewItem item = lvCategory.SelectedItems[0];

			//Hiển thị dữ liệu lên Textbox
			txtCategoryID.Text = item.Text;
			txtCategoryName.Text = item.SubItems[1].Text;
			txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

			//Hiển thị nút cập nhật và xóa
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn cho đối tượng Command
			sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtCategoryName.Text + "', [TYPE] = " + txtType.Text + "WHERE ID = " + txtCategoryID.Text;

			//Mở kết nối tới CSDL
			sqlConnection.Open();

			//Thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				//cập nhật lại dữ liệu trên listview
				ListViewItem item = lvCategory.SelectedItems[0];
				item.SubItems[1].Text = txtCategoryName.Text;
				item.SubItems[2].Text = txtType.Text;

				//Xóa các ô nhập
				txtCategoryID.Text = "";
				txtCategoryName.Text = "";
				txtType.Text = "";

				//Disable các nút xóa và cập nhật
				btnUpdate.Enabled = false;
				btnDelete.Enabled = false;

				MessageBox.Show("Cập nhật nhóm món ăn thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//tạo đối tượng kết nối
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//thiết lập lệnh truy vấn cho đối tượng command
			sqlCommand.CommandText = "DELETE FROM CATEGORY " + "WHERE ID = " + txtCategoryID.Text;

			//Mở kết nối tới CSDL
			sqlConnection.Open();

			//Thực thi lệnh bằng ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//đóng kết nối
			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				//Cập nhật lại listview
				ListViewItem item = lvCategory.SelectedItems[0];
				lvCategory.Items.Remove(item);

				//Xóa các ô nhập
				txtCategoryID.Text = "";
				txtCategoryName.Text = "";
				txtType.Text = "";

				//Disable nút
				btnUpdate.Enabled = false;
				btnDelete.Enabled = false;

				MessageBox.Show("Xóa nhóm món ăn thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void tsmiDeleteCat_Click(object sender, EventArgs e)
		{
			if (lvCategory.SelectedItems.Count > 0)
				btnDelete.PerformClick();
		}

		private void tsmiViewFood_Click(object sender, EventArgs e)
		{
			if (txtCategoryID.Text != "")
			{
				frmFood frmFood = new frmFood();
				frmFood.Show(this);
				frmFood.LoadFood(Convert.ToInt32(txtCategoryID.Text));
			}
		}

		private void btnViewAccount_Click(object sender, EventArgs e)
		{
			AccountManager accountManager = new AccountManager();
			accountManager.ShowDialog();
		}

		private void btnViewBills_Click(object sender, EventArgs e)
		{
			BillsForm billsForm = new BillsForm();
			billsForm.ShowDialog();
		}

		private void btnListTable_Click(object sender, EventArgs e)
		{
			Table table = new Table();
			table.ShowDialog();
		}
	}
}
