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
	public partial class AddCategory : Form
	{
		public AddCategory()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AddCategory_Load(object sender, EventArgs e)
		{
			this.LoadType();
		}
		public void LoadType()
		{
			string connectionString = "server = .; database = RestaurantManagement; Integrated Security = true";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand cmd = sqlConnection.CreateCommand();

			cmd.CommandText = "SELECT DISTINCT Type FROM Category";
			sqlConnection.Open();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();
			adapter.Fill(table);
			cbbType.DataSource = table;
			cbbType.DisplayMember = "Type";
			sqlConnection.Close();

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "server = .; database = RestaurantManagement; Integrated Security = true";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlCommand.CommandText = "EXECUTE InsertCategory @ID OUTPUT, @Name, @Type";

				sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
				sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@Type", SqlDbType.Int);


				//truyền giá trị
				sqlCommand.Parameters["@ID"].Direction = ParameterDirection.Output;
				sqlCommand.Parameters["@Name"].Value = tbName.Text;
				sqlCommand.Parameters["@Type"].Value = cbbType.SelectedItem;

				sqlConnection.Open();

				int numRowAffected = sqlCommand.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string CategoryID = sqlCommand.Parameters["@ID"].Value.ToString();
					MessageBox.Show("Successfully adding new category", "Message");
					this.resetText();
				}
				else
				{
					MessageBox.Show("Adding category failed");
				}
				sqlConnection.Close();
				sqlConnection.Dispose();
			}

			catch (SqlException  exeption)
			{
				MessageBox.Show(exeption.Message, "SQL Error");
			}
			catch (Exception exeption)
			{
				MessageBox.Show(exeption.Message, "Error");
			}
		}

		private void resetText()
		{
			tbID.ResetText();
			tbName.ResetText();
			cbbType.ResetText();
		}

		
	}
}
