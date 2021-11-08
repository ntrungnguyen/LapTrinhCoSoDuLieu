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

namespace Lab6_Basic_Command
{
	public partial class Table : Form
	{
		public Table()
		{
			InitializeComponent();
			LoadTable();
		}
		public void LoadTable()
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "SELECT * FROM [Table]";

			sqlConnection.Open();

			this.Text = "Bàn";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Table");
			da.Fill(dt);

			dgvTable.DataSource = dt;

			dgvTable.DataSource = dt;
			dgvTable.Columns[0].HeaderText = "ID";
			dgvTable.Columns[1].HeaderText = "Tên bàn";
			dgvTable.Columns[2].HeaderText = "Trạng thái";
			dgvTable.Columns[3].HeaderText = "Sức chứa";

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnAddtable_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = string.Format($"INSERT INTO [Table](Name, Status, Capacity) VALUES (N'{tbTableName.Text}', {(cbbStatus.Text == "Trống" ? 0 : 1)}, {tbCapacity.Text})");

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm bàn thành công");
				LoadTable();
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}

			sqlConnection.Close();
			sqlConnection.Dispose();
		}

		private void btnDeleteTable_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string findID = dgvTable.CurrentRow.Cells[0].Value.ToString();

			sqlCommand.CommandText = $"DELETE FROM [Table] WHERE ID = {findID}";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				dgvTable.Rows.Remove(dgvTable.CurrentRow);
				MessageBox.Show("Xóa bàn thành công");
				LoadTable();
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnUpdateTable_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string findTable = dgvTable.CurrentRow.Cells[0].Value.ToString();

			sqlCommand.CommandText = $"UPDATE [Table] SET Name = '{tbTableName.Text}', Status = {(cbbStatus.Text == "Trống" ? "0" : "1")}, Capacity = {tbCapacity.Text} WHERE ID = {findTable}";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				dgvTable.Rows.Remove(dgvTable.CurrentRow);
				MessageBox.Show("Cập nhật bàn thành công");
				LoadTable();
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
			
		}

		private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void dgvTable_Click(object sender, EventArgs e)
		{
			int index = dgvTable.CurrentRow.Index;

			tbTableName.Text = dgvTable.Rows[index].Cells["Name"].Value.ToString();
			cbbStatus.Text = dgvTable.Rows[index].Cells["Status"].Value.ToString() == "0" ? "Trống" : "Có người";
			tbCapacity.Text = dgvTable.Rows[index].Cells["Capacity"].Value.ToString();
		}

		private void tsmiDeleteTable_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string findID = dgvTable.CurrentRow.Cells[0].Value.ToString();

			sqlCommand.CommandText = $"DELETE FROM [Table] WHERE ID = {findID}";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				dgvTable.Rows.Remove(dgvTable.CurrentRow);
				MessageBox.Show("Xóa bàn thành công");
				LoadTable();
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}
	}
}
