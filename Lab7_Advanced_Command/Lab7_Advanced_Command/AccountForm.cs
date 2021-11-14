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
	public partial class AccountForm : Form
	{
		public AccountForm()
		{
			InitializeComponent();
		}
		public void LoadAccount()
        {
			try
            {
				this.Text = "Tài khoản";
				string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandText = "SELECT * FROM Account";

				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();

				sqlConnection.Open();
				adapter.Fill(dataTable);
				dgvAccount.DataSource = dataTable;

				dgvAccount.Columns[0].HeaderText = "Tên tài khoản";
				dgvAccount.Columns[1].HeaderText = "Mật khẩu";
				dgvAccount.Columns[2].HeaderText = "Tên đầy đủ";
				dgvAccount.Columns[3].HeaderText = "Email";
				dgvAccount.Columns[4].HeaderText = "Số điện thoại";
				dgvAccount.Columns[5].HeaderText = "Ngày tạo";

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

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
			LoadAccount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
			tbAccountName.Text = "";
			tbFullName.Text = "";
			tbPassword.Text = "";
			tbEmail.Text = "";
			tbTell.Text = "";
		}

        private void dgvAccount_Click(object sender, EventArgs e)
        {
			try
            {
				int index = dgvAccount.CurrentRow.Index;

				tbAccountName.Text = dgvAccount.Rows[index].Cells["AccountName"].Value.ToString();
				tbPassword.Text = dgvAccount.Rows[index].Cells["Password"].Value.ToString();
				tbFullName.Text = dgvAccount.Rows[index].Cells["FullName"].Value.ToString();
				tbEmail.Text = dgvAccount.Rows[index].Cells["Email"].Value.ToString();
				tbTell.Text = dgvAccount.Rows[index].Cells["Tell"].Value.ToString();
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

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
				string connectionString = "server =.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				string findAccount = dgvAccount.CurrentRow.Cells[0].Value.ToString();


				sqlCommand.CommandText = "EXEC UpdateAccount @AccountName, @Password, @FullName, @Email, @Tell, @DataCreated";

				sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 200);
				sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@Tell", SqlDbType.NVarChar, 200);
				sqlCommand.Parameters.Add("@DataCreated", SqlDbType.SmallDateTime);

				sqlCommand.Parameters["@AccountName"].Value = tbAccountName.Text;
				sqlCommand.Parameters["@Password"].Value = tbPassword.Text;
				sqlCommand.Parameters["@FullName"].Value = tbFullName.Text;
				sqlCommand.Parameters["@Email"].Value = tbEmail.Text;
				sqlCommand.Parameters["@Tell"].Value = tbTell.Text;
				sqlCommand.Parameters["@DataCreated"].Value = DateTime.Now;

				sqlConnection.Open();

				int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

				sqlConnection.Close();

				if (numOfRowsEffected == 1)
				{
					dgvAccount.Rows.Remove(dgvAccount.CurrentRow);
					MessageBox.Show("Cập nhật tài khoản thành công");
					LoadAccount();
				}
				else
				{
					MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
				}
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

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
			try
			{
				string connectionString = "server = .; database = RestaurantManagement; Integrated Security = true";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandText = "EXEC InsertAccount @AccountName, @Password, @FullName, @Email, @Tell, @DateCreated";

				sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 300);
				sqlCommand.Parameters.Add("@Tell", SqlDbType.NVarChar, 100);
				sqlCommand.Parameters.Add("@DateCreated", SqlDbType.SmallDateTime);

				sqlCommand.Parameters["@AccountName"].Value = tbAccountName.Text;
				sqlCommand.Parameters["@Password"].Value = tbPassword.Text;
				sqlCommand.Parameters["@FullName"].Value = tbFullName.Text;
				sqlCommand.Parameters["@Email"].Value = tbEmail.Text;
				sqlCommand.Parameters["@Tell"].Value = tbTell.Text;
				sqlCommand.Parameters["@DateCreated"].Value = DateTime.Now.ToShortDateString();

				sqlConnection.Open();

				int num = sqlCommand.ExecuteNonQuery();
				if (num == 1)
				{
					LoadAccount();
					tbAccountName.Text = "";
					tbFullName.Text = "";
					tbPassword.Text = "";
					tbEmail.Text = "";
					tbTell.Text = "";
					MessageBox.Show("Thêm tài khoản thành công!");
				}
				else
				{
					MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại");
				}
				sqlConnection.Close();

			}
			catch (SqlException exeption)
			{
				MessageBox.Show(exeption.Message, "SQL Error");
			}
			catch (Exception exeption)
			{
				MessageBox.Show(exeption.Message, "Error");
			}

		}

        private void tsmiViewRole_Click(object sender, EventArgs e)
        {

        }
    }
}
