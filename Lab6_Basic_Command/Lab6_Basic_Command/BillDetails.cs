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
	public partial class BillDetails : Form
	{
		int billID;
		public BillDetails()
		{
			InitializeComponent();
		}
		public void LoadBillDetails(int billID)
		{
			this.billID = billID;
			string connectionString = "server=. ; database = RestaurantManagement; Integrated Security = true ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT Name FROM Bills WHERE ID = " + billID;

			sqlConnection.Open();

			string billName = sqlCommand.ExecuteScalar().ToString();
			this.Text = billName + "ID + " + billID;

			string query = string.Format("SELECT Name, Unit, Price, Quantity, Price * Quantity AS Total FROM BillDetails " +
				"JOIN Food ON BillDetails.FoodID = Food.ID " + "WHERE BillDetails.ID = {0}", billID).ToString();
			sqlCommand.CommandText = query;

			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			dgvBillDetails.DataSource = dt;

			dgvBillDetails.Columns[0].HeaderText = "Tên";
			dgvBillDetails.Columns[1].HeaderText = "Loại";
			dgvBillDetails.Columns[2].HeaderText = "Giá";
			dgvBillDetails.Columns[3].HeaderText = "Số lượng";
			dgvBillDetails.Columns[4].HeaderText = "Tổng cộng";

			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
