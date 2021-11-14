using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Advanced_Command
{
	public partial class Form1 : Form
	{
		private DataTable foodTable;
		public Form1()
		{
			InitializeComponent();
		}

		private void LoadCategory()
		{
			string connectionString = "server=. ; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable();

			sqlConnection.Open();

			adapter.Fill(dt);

			sqlConnection.Close();
			sqlConnection.Dispose();

			cbbCategory.DataSource = dt;
			cbbCategory.DisplayMember = "Name";
			cbbCategory.ValueMember = "ID";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoadCategory();
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbCategory.SelectedIndex == -1)
				return;

			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

			sqlCommand.Parameters.Add("@categoryId", SqlDbType.Int);

			if (cbbCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
				sqlCommand.Parameters["@categoryId"].Value = rowView["ID"];
			}
			else
			{
				sqlCommand.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
			}

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			foodTable = new DataTable();

			sqlConnection.Open();

			adapter.Fill(foodTable);

			sqlConnection.Close();
			sqlConnection.Dispose();

			//đưa dữ liệu vào data gridview
			dgvFoodList.DataSource = foodTable;

			//Tính số lượng mẫu tin
			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cbbCategory.Text;
		}

		private void tsmiCalculateQuantity_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			//Lấy thông tin sản phẩm được chọn
			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				//Truyền tham số
				sqlCommand.Parameters.Add("@foodId", SqlDbType.Int);
				sqlCommand.Parameters["@foodId"].Value = rowView["ID"];

				sqlCommand.Parameters.Add("@numSaleFood", SqlDbType.Int);
				sqlCommand.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();

				string result = sqlCommand.Parameters["@numSaleFood"].Value.ToString();
				MessageBox.Show("Tổng số lượng món " + rowView["Name"] + "đã bán là: " + result + " " + rowView["Unit"]);

				sqlConnection.Close();
			}
			sqlCommand.Dispose();
			sqlConnection.Dispose();
		}

		private void tsmiAddFood_Click(object sender, EventArgs e)
		{
			FoodInfoForm foodForm = new FoodInfoForm();
			foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);
			foodForm.Show(this);
		}

		private void foodForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cbbCategory.SelectedIndex;
			cbbCategory.SelectedIndex = -1;
			cbbCategory.SelectedIndex = index;
		}

		private void tsmiUpdateFood_Click(object sender, EventArgs e)
		{
			//lấy thông tin sản phẩm được chọn
			if (dgvFoodList.SelectedRows.Count > 0)
			{
                //DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                //DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                //FoodInfoForm foodForm = new FoodInfoForm();
                //foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

                //foodForm.Show(this);
                //foodForm.DisplayFoodInfo(rowView);
            }
		}

		private void txtSearchByName_TextChanged(object sender, EventArgs e)
		{
			if (foodTable == null) return;

			//tạo bộ lọc và sắp xếp biểu thức
			string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
			string sortExpression = "Price DESC";
			DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

			//tạo một đối tượng xem dữ liệu để xem dữ liệu trong bảng dữ liệu foodTable
			//lọc theo tên (chứa 'ng') và sắp xếp giảm dần theo giá
			DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);

			dgvFoodList.DataSource = foodView;
		}

        private void tsmiAccount_Click(object sender, EventArgs e)
        {
			AccountForm accountForm = new AccountForm();
			accountForm.Show(this);
        }

        private void tsmiOrder_Click(object sender, EventArgs e)
        {
			OrdersForm ordersForm = new OrdersForm();
			ordersForm.Show(this);
        }
    }
}
