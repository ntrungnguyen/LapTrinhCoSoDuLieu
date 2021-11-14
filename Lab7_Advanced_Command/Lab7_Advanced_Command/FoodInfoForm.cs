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
	public partial class FoodInfoForm : Form
	{
		public FoodInfoForm()
		{
			InitializeComponent();
		}

		private void FoodInfoForm_Load(object sender, EventArgs e)
		{
			InitValues();
		}

		private void InitValues()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataSet ds = new DataSet();

			sqlConnection.Open();

			//lấy dữ liệu từ csdl đưa vào datatable
			adapter.Fill(ds, "Category");

			//hiển thị món ăn
			cbbCatName.DataSource = ds.Tables["Category"];
			cbbCatName.DisplayMember = "Name";
			cbbCatName.ValueMember = "ID";

			sqlConnection.Close();
			sqlConnection.Dispose();
		}

		private void resetText()
		{
			txtFoodID.ResetText();
			txtName.ResetText();
			txtNotes.ResetText();
			txtUnit.ResetText();
			cbbCatName.ResetText();
			nudPrice.ResetText();
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

				sqlCommand.Parameters.Add("@id", SqlDbType.Int);
				sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@foodCategoryId", SqlDbType.Int);
				sqlCommand.Parameters.Add("@price", SqlDbType.Int);
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				sqlCommand.Parameters["@id"].Direction = ParameterDirection.Output;

				//Truyền giá trị vào thủ tục qua tham số
				sqlCommand.Parameters["@name"].Value = txtName.Text;
				sqlCommand.Parameters["@unit"].Value = txtUnit.Text;
				sqlCommand.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
				sqlCommand.Parameters["@price"].Value = nudPrice.Value;
				sqlCommand.Parameters["@notes"].Value = txtNotes.Text;

				sqlConnection.Open();

				int numRowAffected = sqlCommand.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string foodID = sqlCommand.Parameters["@id"].Value.ToString();

					MessageBox.Show("Successfully adding new food. Food ID = " + foodID, "Message");
					this.resetText();
				}
				else
				{
					MessageBox.Show("Adding food failed");
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
			}

			//bắt lỗi sql và các lỗi khác
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}

			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		public void DisplayFoodInfo(DataRowView rowView)
		{
			try
			{
				txtFoodID.Text = rowView["ID"].ToString();
				txtName.Text = rowView["Name"].ToString();
				txtUnit.Text = rowView["Unit"].ToString();
				txtNotes.Text = rowView["Notes"].ToString();
				nudPrice.Text = rowView["Prive"].ToString();

				cbbCatName.SelectedIndex = -1;

				//chọn nhóm món ăn tương ứng
				for (int index = 0; index < cbbCatName.Items.Count; index++)
				{
					DataRowView cat = cbbCatName.Items[index] as DataRowView;
					if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
					{
						cbbCatName.SelectedIndex = index;
						break;
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
				this.Close();
			}
		}

		private void btnUpdateFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandText = "EXCUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

				//Thêm tham số vào đối tượng command
				sqlCommand.Parameters.Add("@id", SqlDbType.Int);
				sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@foodCategoryId", SqlDbType.Int);
				sqlCommand.Parameters.Add("@price", SqlDbType.Int);
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				//Truyền giá trị vào thủ tục qua tham số
				sqlCommand.Parameters["@id"].Value = int.Parse(txtFoodID.Text);
				sqlCommand.Parameters["@name"].Value = txtName.Text;
				sqlCommand.Parameters["@unit"].Value = txtUnit.Text;
				sqlCommand.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
				sqlCommand.Parameters["@price"].Value = nudPrice.Value;
				sqlCommand.Parameters["@notes"].Value = txtNotes.Text;

				sqlConnection.Open();

				int numRowAffected = sqlCommand.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					MessageBox.Show("Successfully updating food", "Message");
					this.resetText();
				}
				else
				{
					MessageBox.Show("Updating food failed");
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			AddCategory addCategory = new AddCategory();
			addCategory.Show();
		}
	}
}
