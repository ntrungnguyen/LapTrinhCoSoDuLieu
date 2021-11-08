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
	public partial class AccountManager : Form
	{
		public AccountManager()
		{
			InitializeComponent();
			LoadAccountManager();
		}
		public void LoadAccountManager()
		{
			string connectionString = "server=. ; database = RestaurantManagement; Integrated Security = true ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT * FROM Account";

			sqlConnection.Open();

			this.Text = "Quản lý tài khoản";

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Account");
			da.Fill(dt);

			dgvAccountManager.DataSource = dt;

			dgvAccountManager.Columns[0].HeaderText = "Tên tài khoản";
			dgvAccountManager.Columns[1].HeaderText = "Mật khẩu";
			dgvAccountManager.Columns[2].HeaderText = "Tên đầy đủ";
			dgvAccountManager.Columns[3].HeaderText = "Email";
			dgvAccountManager.Columns[4].HeaderText = "Số điện thoại";
			dgvAccountManager.Columns[5].HeaderText = "Ngày tạo";

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnResetAccount_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = True ";

			string findName = dgvAccountManager.CurrentRow.Cells[0].Value.ToString();
			string defaultPassword = "12345678";

			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = $"UPDATE Account SET Password = '{defaultPassword}' WHERE AccountName = '{findName}'";
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			if (numOfRowsEffected == 1)
			{ 
				MessageBox.Show("Reset thành công");
				LoadAccountManager();
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
			sqlConnection.Close();
		}

		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = $"INSERT INTO [Account](AccountName, [Password], FullName, Email, Tell, DataCreated) VALUES (N'{tbAccountName.Text}', N'{tbPassword.Text}', N'{tbName}', N'{tbEmail.Text}', N'{tbTell.Text}')";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				MessageBox.Show("Thêm tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}


			sqlConnection.Close();
			sqlConnection.Dispose();
		}

		private void tsmiDeleteAccount_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string findAccount = dgvAccountManager.CurrentRow.Cells[0].Value.ToString();

			sqlCommand.CommandText = $"DELETE FROM Account WHERE ID = {findAccount}";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				dgvAccountManager.Rows.Remove(dgvAccountManager.CurrentRow);
				MessageBox.Show("Xóa tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnUpdateAccount_Click(object sender, EventArgs e)
		{
			string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			string findAccount = dgvAccountManager.CurrentRow.Cells[0].Value.ToString();


			sqlCommand.CommandText = $"UPDATE Account SET AccountName = '{tbAccountName}', [Password] = '{tbPassword}', FullName = '{tbName}', Email = '{tbEmail}', Tell = '{tbTell}', DataCreated = '{dateTimePicker1}' WHERE ID = {findAccount}";

			sqlConnection.Open();

			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();

			if (numOfRowsEffected == 1)
			{
				dgvAccountManager.Rows.Remove(dgvAccountManager.CurrentRow);
				MessageBox.Show("Cập nhật tài khoản thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnXoaTrang_Click(object sender, EventArgs e)
		{
			tbAccountName.Text = "";
			tbName.Text = "";
			tbPassword.Text = "";
			tbEmail.Text = "";
			tbTell.Text = "";
		}

		private void dgvAccountManager_Click(object sender, EventArgs e)
		{
			int index = dgvAccountManager.CurrentRow.Index;

			tbAccountName.Text = dgvAccountManager.Rows[index].Cells["AccountName"].Value.ToString();
			tbPassword.Text = dgvAccountManager.Rows[index].Cells["Password"].Value.ToString();
			tbName.Text = dgvAccountManager.Rows[index].Cells["FullName"].Value.ToString();
			tbEmail.Text = dgvAccountManager.Rows[index].Cells["Email"].Value.ToString();
			tbTell.Text = dgvAccountManager.Rows[index].Cells["Tell"].Value.ToString();

		}
	}
}
